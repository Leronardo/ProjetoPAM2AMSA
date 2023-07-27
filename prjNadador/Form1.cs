using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjNadador
{
    public partial class frmNadador : Form
    {
        public frmNadador()
        {
            InitializeComponent();
        }
        int tot10, tot17, tot59, tot60;
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTotais_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Totais por faixa etária" + "\n" +
                "0 a 10 anos:" + tot10 + "\n" +
                "11 a 17 anos:" + tot17 + "\n" +
                "18 a 59 anos:" + tot59 + "\n" +
                "60 ou mais anos:" + tot60,
                "Total", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            rb10.Checked = false;
            rb17.Checked = false;
            rb59.Checked = false;
            rb60.Checked = false;
        }

        private void frmNadador_Load(object sender, EventArgs e)
        {

        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || (rb10.Checked == false &&
                rb17.Checked == false && rb59.Checked == false &&
                    rb60.Checked == false))
            {
                MessageBox.Show("Nome ou faixa etária não preenchidos",
                 "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else
            {
                if (rb10.Checked == true)
                {
                    tot10++;
                }
                else
                
                    if (rb17.Checked == true)
                    {
                        tot17++;
                    }
                    else
                    
                        if (rb59.Checked == true)
                        {
                            tot59++;
                        }
                        else
                        
                            if (rb60.Checked == true) 
                            {
                                tot60++;
                            }
                          
             
                        MessageBox.Show("Opção confirmada com sucesso",
                              "Confirmação", MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                    }
                }
            }
        }
    
