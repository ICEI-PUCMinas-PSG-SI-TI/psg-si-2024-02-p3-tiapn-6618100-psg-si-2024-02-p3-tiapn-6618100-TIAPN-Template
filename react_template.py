import os

structure = {
    "src": {
        "frontend": {
            "public": ["index.html"],
            "src": {
                "assets": [],
                "components": [],
                "pages": [],
                "hooks": [],
                "contexts": [],
                "services": [],
                "utils": [],
                "App.js": "",
                "index.js": ""
            },
            "package.json": ""
        }
    }
}


def create_structure(base_path, structure):
    """
    Cria a estrutura de diretórios e arquivos.

    :param base_path: Caminho base para iniciar a criação.
    :param structure: Dicionário que define a estrutura de pastas e arquivos.
    """
    for name, content in structure.items():
        path = os.path.join(base_path, name)
        if isinstance(content, dict):
            os.makedirs(path, exist_ok=True)
            create_structure(path, content)
        elif isinstance(content, list):
            os.makedirs(path, exist_ok=True)
            for file_name in content:
                file_path = os.path.join(path, file_name)
                with open(file_path, "w") as f:
                    f.write("")
        else:
            with open(path, "w") as f:
                f.write(content)


base_path = os.path.join(os.getcwd(), "src")
create_structure(base_path, structure)

print("Done.")
