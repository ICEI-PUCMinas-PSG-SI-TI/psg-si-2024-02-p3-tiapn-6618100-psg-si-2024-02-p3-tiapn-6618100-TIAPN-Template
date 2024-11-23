from flask import Flask, render_template, request, jsonify
import requests
from datetime import datetime, timezone

app = Flask(__name__, template_folder='template')

# URL base da API Swagger
# API_BASE_URL = "http://localhost:8080/api"
API_BASE_URL = 'https://localhost:44308/api'

# Funções auxiliares para comunicação com a API
def criar_aluno(data):
    aluno_payload = {
        "nome": data.get("nome"),
        "matricula": "string",
        "rua": data["endereco"].get("rua"),
        "bairro": data["endereco"].get("bairro"),
        "numero": data["endereco"].get("numero"),
        "cep": data["endereco"].get("cep"),
        "telefone": data.get("telefone"),
        "email": data.get("email")
    }
    response = requests.post(f"{API_BASE_URL}/Aluno", json=aluno_payload, verify=False)
    if response.status_code == 201:
        return response.json().get("codigo_aluno")
    else:
        raise Exception(f"Erro ao criar aluno: {response.json()}")


def criar_pagamento(data):
    pagamento_payload = {
        "tipo": data["pagamento"].get("plano"),
        "nome_cartao": data["pagamento"].get("nomeCartao"),
        "numero_cartao": data["pagamento"].get("numeroCartao"),
        "validade": data["pagamento"].get("validade"),
        "codigo_seguranca": data["pagamento"].get("codigoSeguranca"),
        "status": "Pago"
    }
    response = requests.post(f"{API_BASE_URL}/Pagamento", json=pagamento_payload, verify=False)
    if response.status_code == 201:
        return response.json().get("codigo_pagamento")
    else:
        raise Exception(f"Erro ao criar pagamento: {response.json()}")


def criar_matricula(aluno_id, pagamento_id, data):
    matricula_payload = {
        "codigo_matricula": 0,  # A API espera 0 para nova matrícula
        "codigo_aluno": aluno_id,
        "codigo_turma": int(data.get("curso")),
        "codigo_pagamento": pagamento_id,
        "codigo_administrador": 1,  # ID fixo do administrador
        "data_inicio": datetime.now(timezone.utc).strftime("%Y-%m-%dT%H:%M:%S.%f")[:-3] + "Z",  # ISO 8601 UTC
        "status": "Ativo",  # Ajustar conforme necessário
        "aluno": {
            "codigo_aluno": aluno_id,
            "nome": data.get("nome"),
            "matricula": "MATRICULA_VALIDADA",  # Valor válido para o campo matricula
            "rua": data["endereco"].get("rua"),
            "bairro": data["endereco"].get("bairro"),
            "numero": data["endereco"].get("numero"),
            "cep": data["endereco"].get("cep"),
            "telefone": data.get("telefone"),
            "email": data.get("email")
        },
        "turma": {
            "codigo_turma": int(data.get("curso")),
            "nome": "Nome da turma",  # Preencher dinamicamente se disponível
            "sala": 1,
            "nivel": "Iniciante",
            "duracao": "03:00:00",  # Valor compatível com TimeSpan (3 horas)
            "numero_vagas": 10
        },
        "pagamento": {
            "codigo_pagamento": pagamento_id,
            "tipo": data["pagamento"].get("plano"),
            "nome_cartao": data["pagamento"].get("nomeCartao"),
            "numero_cartao": data["pagamento"].get("numeroCartao"),
            "validade": data["pagamento"].get("validade"),
            "codigo_seguranca": data["pagamento"].get("codigoSeguranca"),
            "status": "Pago"
        },
        "administrador": {
            "codigo_administrador": 1,
            "nome": "Administrador Geral",
            "contato": "admin@exemplo.com",
            "tipo": "Gerente"
        }
    }

    # Exibindo o payload para validação
    print("Payload enviado para matrícula:", matricula_payload)

    response = requests.post(f"{API_BASE_URL}/Matricula", json=matricula_payload, verify=False)

    # Exibir a resposta da API
    print(f"Resposta da API (status {response.status_code}): {response.text}")

    if response.status_code != 201:
        raise Exception(f"Erro ao criar matrícula. Resposta: {response.text}")


# Rota principal para a página de matrícula
@app.route('/')
def matricula():
    try:
        # Obter cursos e instrumentos da API
        cursos = requests.get(f"{API_BASE_URL}/Turma", verify=False).json()
        instrumentos = requests.get(f"{API_BASE_URL}/Instrumento", verify=False).json()
        dias_semana = ["Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira"]
    except requests.exceptions.RequestException as e:
        print(f"Erro ao conectar à API: {e}")
        cursos, instrumentos, dias_semana = [], [], []

    # Renderizar o template com os dados
    return render_template('matricula.html', cursos=cursos, instrumentos=instrumentos, dias_semana=dias_semana)


# Endpoint para enviar os dados de matrícula para a API
@app.route('/submit', methods=['POST'])
def submit_matricula():
    data = request.json

    # Validação básica
    if not data:
        return jsonify({"error": "Dados inválidos"}), 400

    try:
        # Etapas do processo de matrícula
        aluno_id = criar_aluno(data)
        pagamento_id = criar_pagamento(data)
        criar_matricula(aluno_id, pagamento_id, data)

        return jsonify({"message": "Matrícula realizada com sucesso"}), 201

    except Exception as e:
        print(f"Erro ao processar matrícula: {e}")
        return jsonify({"error": "Erro interno ao processar matrícula", "details": str(e)}), 500



if __name__ == "__main__":
    app.run(debug=True)
