using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class frmRolagem : Form
    {
        public frmRolagem()
        {
            InitializeComponent();
        }
        public bool teste;

        private void DiceSelect_Click(object sender, EventArgs e)
        { 
            Random random = new Random();
            //Verifica se a opção de soma foi selecionada
            if (chkSoma.Checked)
            {

                //Rolando os valores aleatóriamente usando o objeto instanciado Random;
                int[] dado = new int[int.Parse(numQntDad.Value.ToString())];
                
                if (numQntDad.Value == 0)
                {
                    dado = new int[int.Parse(numQntDad.Value.ToString()) + 1];
                }
                if(numQntDad.Value != 0) {
                    dado = new int[int.Parse(numQntDad.Value.ToString())];
                }

                for (int i = 0; i < dado.Length; i++)
                {
                    dado[i] = random.Next(1, int.Parse(((Button)sender).Text));
                }
                //Método para ordenar os valores dentro de um vetor em ordem crescente
                ordenaDec(dado, int.Parse(numQntDad.Value.ToString()));
                string dadosordenados = "";
                int somadosdados = 0;
                for (int i = 0; i < dado.Length; i++)
                {
                    //Este if serve para quando chegar no último item do vetor, ele somar o valor na variável sem a vírgula, e acabar com o laço
                    if (i == dado.Length - 1)
                    {
                        dadosordenados += dado[i].ToString();
                        somadosdados += dado[i];
                        continue;
                    }
                    dadosordenados += dado[i].ToString() + " + ";
                    somadosdados += dado[i];
                }
                MessageBox.Show("A Soma das Rolagens é: " + (somadosdados + numSoma.Value) + " (" + dadosordenados + " + " + numSoma.Value.ToString() + ")" );
            }
            //Verifica se a opção de soma não está selecionada
            if (!chkSoma.Checked)
            {
                //Rolagem de Dado único
                if ((numQntDad.Value == 1) || (numQntDad.Value == 0)) { 
                    int soma1 = random.Next(1, int.Parse(((Button)sender).Text));
                    string resultado = (soma1 + numSoma.Value).ToString();
                    MessageBox.Show("O Resultado do dado é: " + resultado + " ("+ soma1 + " + "+ numSoma.Value.ToString() + ")");
                }
                 // Rolagem de Dados múltiplos:
                if(numQntDad.Value > 1)
                {
                    if (chkPior.Checked) 
                    {
                        //Rolando os valores aleatóriamente usando o objeto instanciado Random;
                        int[] dado = new int[int.Parse(numQntDad.Value.ToString())];
                        for (int i = 0; i < dado.Length; i++)
                        {
                            dado[i] = random.Next(1, int.Parse(((Button)sender).Text));
                        }
                        //Método para ordenar os valores dentro de um vetor em ordem crescente
                        ordenaCre(dado, int.Parse(numQntDad.Value.ToString()));
                        string dadosordenados = "";
                        for (int i = 0; i < dado.Length; i++)
                        {
                            //Este if serve para quando chegar no último item do vetor, ele somar o valor na variável sem a vírgula, e acabar com o laço
                            if (i == dado.Length - 1)
                            {
                                dadosordenados += dado[i].ToString();
                                continue;
                            }
                            dadosordenados += dado[i].ToString() + ", ";
                        }
                        MessageBox.Show("O Menor resultado foi: " + (dado[0] + int.Parse(numSoma.Value.ToString()) + " (" + dado[0] + " + " + numSoma.Value.ToString() + ")" + "\n\nresultados:" + dadosordenados));

                    }
                    if (!chkPior.Checked)
                    {

                    //Rolando os valores aleatóriamente usando o objeto instanciado Random;
                    int[] dado = new int[int.Parse(numQntDad.Value.ToString())];
                    for(int i = 0; i < dado.Length; i++)
                    {
                        dado[i] = random.Next(1, int.Parse(((Button)sender).Text));
                    }
                    //Método para ordenar os valores dentro de um vetor em ordem crescente
                    ordenaDec(dado, int.Parse(numQntDad.Value.ToString()));
                    string dadosordenados = "";
                    for(int i = 0; i < dado.Length; i++)
                    {
                        //Este if serve para quando chegar no último item do vetor, ele somar o valor na variável sem a vírgula, e acabar com o laço
                        if(i == dado.Length - 1)
                        {
                            dadosordenados += dado[i].ToString();
                            break;
                        }
                        dadosordenados += dado[i].ToString() + ", ";
                    }
                    MessageBox.Show("O maior resultado foi: "+ (dado[0] + int.Parse(numSoma.Value.ToString()) + " (" + dado[0] + " + " + numSoma.Value.ToString() + ")" +"\n\nresultados:" + dadosordenados));
                    }
                }
            }
            
            
        }
        void ordenaDec(int[] vetor, int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = i; j < tamanho; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        int temp = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = temp;
                    }
                }
            }
        }
        void ordenaCre(int[] vetor, int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = i; j < tamanho; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        int temp = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = temp;
                    }
                }
            }
        }

        private void numQntDad_ValueChanged(object sender, EventArgs e)
        {
             teste = Validate(true);

            MessageBox.Show(teste.ToString());

            if (!(((NumericUpDown)sender).Value.ToString().IndexOf(',') == -1))
            {
                MessageBox.Show("Não usa valor decimal bobão! >:(");
                ((NumericUpDown)sender).Value = 0;
            }
        }

        private void numQntDad_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("");
            
        }

        private void numQntDad_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Validated");
        }
        
    }
    
}
