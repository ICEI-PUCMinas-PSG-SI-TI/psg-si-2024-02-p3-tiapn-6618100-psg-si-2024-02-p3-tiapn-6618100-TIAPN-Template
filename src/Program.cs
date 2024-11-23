using BodyShape_TI;
using BodyShape_TI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BS_Projeto
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaSprint4());

            //BodyShape_TI.Forms.FormCadastroPlano -> Cadastro de plano
            //BodyShape_TI.Forms.FormCadastroAlunoPlano -> Associar aluno a plano
            //FormCadastroAluno -> Cadastrar aluno
        }
    }
}
