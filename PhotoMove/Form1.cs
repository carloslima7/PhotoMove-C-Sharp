using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace PhotoMove
{
    public partial class PhotoMove : Form
    {
        public PhotoMove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.Rows.Clear(); 
            //Cria objeto utilizado para selecionar diretórios
            FolderBrowserDialog dlgFolder = new FolderBrowserDialog();
            dlgFolder.Description = "Seleciona a pasta a ser copiada:";

            if (dlgFolder.ShowDialog() != DialogResult.Cancel)
            {
                fonte.Text = dlgFolder.SelectedPath;
                DirectoryInfo dirInfo = new DirectoryInfo(dlgFolder.SelectedPath);
                int contador = 0;
                
                //Obtem a lista de árquivos no diretório
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                  
                    string jpg = file.Name;
                    if (jpg.Contains(".jpg") || jpg.Contains(".JPG") || jpg.Contains(".Jpg") ||jpg.Contains(".jPg") || jpg.Contains(".jpG"))
                    {
                        data.Rows.Add();
                        data[0, contador].Value = jpg;
                        contador++;
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fonte.Text =="" )
            {
                MessageBox.Show("Favor Inserir a Pasta Origem das Imagens");
                return;
            }
            if (Destino.Text == "")
            {
                MessageBox.Show("Favor Inserir a Pasta o Destino das Imagens");
                return;
            }
            else
            { 
                string sourceFile = string.Empty;
                string destinationFile = string.Empty;
                
                for (int i = 0; i < (data.RowCount - 1); i++)
                {
                    if (data.Rows[i].Cells[1].Value != null)
                    {
                        string x = data.Rows[i].Cells[0].Value.ToString();
                        destinationFile = Path.Combine(Destino.Text, x);
                        sourceFile = Path.Combine(fonte.Text,x);

                        if (System.IO.File.Exists(destinationFile))
                        {
                            ;
                        }
                        else
                        {
                            File.Copy(sourceFile, destinationFile);
                            x = string.Empty;
                        }
                    }
                    
                }
                MessageBox.Show("Imagens Copiadas com Sucesso");
                sourceFile = string.Empty;
                destinationFile = string.Empty;
            } 
            
                     
        
            
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
                    
            //Cria objeto utilizado para selecionar diretórios
            FolderBrowserDialog dlgFolder = new FolderBrowserDialog();
            dlgFolder.Description = "Seleciona a pasta de destino:";
            dlgFolder.ShowDialog();
            Destino.Text = dlgFolder.SelectedPath;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                excel.Text = openFileDialog1.FileName;
                sr.Close();
            }


            StreamReader stream = new StreamReader(excel.Text);

            string linha = null;


            while ((linha = stream.ReadLine()) != null)
            {
                string[] coluna = linha.Split(';');

                for (int i = 0; i < (data.RowCount - 1); i++)
                {
                    string x = data.Rows[i].Cells[0].Value.ToString();
                    x = x.Replace(".jpg","");
                    x = x.Replace(".png", "");
                    x = x.Replace(".JPG", "");
                    x = x.Replace(".JPg", "");
                    x = x.Replace(".jPG", "");
                    x = x.Replace(".jpG", "");
                    x = x.Replace(".jPg", "");
                    if ( x == coluna[0].ToString())
                    {
                        data.Rows[i].Cells[1].Value = true;
                    }
                }
                
                
           
            }

            stream.Close();
        }

    
    }
}
