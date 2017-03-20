using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.DirectoryServices;

namespace WindowsFormsApplication12
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadAd A = new ReadAd();
            
            if (AD.ValidateCredentials(textBox1.Text, textBox2.Text))
            {

                string[] OU = AD.GetUser(textBox1.Text).DistinguishedName.Split(',');
                Form1 _Form1 = new Form1();
                
                _Form1.Show();
                
                _Form1.Text = "Административный модуль | Пользователь: " + OU[0].Substring(3, OU[0].Length - 3) + " | Группа: " + OU[1].Substring(3, OU[1].Length - 3);
                this.Hide();
            }
              else
            {
                MessageBox.Show("Неверный логин");
            }
            



        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void Form13_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
    

                    


                    
                        
                            
                        
                      

                   
                
            
            
            
            

            





            

                
            
                
    
            
        
    

            
            


                    
            
            
    
                    


           
       
            
    
           

                
            


         
            
               
           

        
                
            
        
    

      
               
            
       
    

        
    


                
            
          

            
               
            


        
   

