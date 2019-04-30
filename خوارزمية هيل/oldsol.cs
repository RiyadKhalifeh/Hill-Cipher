//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using Bluebit.MatrixLibrary;

//namespace خوارزمية_هيل
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//            comboBox1.SelectedIndex = 1;
//            alphabets = comboBox1.Text;
//            //MessageBox.Show(Convert.ToString((int)a));
//        }

//        public static int Mod(int a, int n)
//        {
//            return a - (int)Math.Floor((double)a / n) * n;
//        }
//        static int GCD(int a, int b)
//        {
//            int Remainder;

//            while (b != 0)
//            {
//                Remainder = a % b;
//                a = b;
//                b = Remainder;
//            }

//            return a;
//        }
//        public static Matrix Minor(Matrix matrix, int iRow, int iCol)
//        {
//            Matrix minor = new Matrix(matrix.Rows - 1, matrix.Cols - 1);
//            int m = 0, n = 0;
//            for (int i = 0; i < matrix.Rows; i++)
//            {
//                if (i == iRow)
//                    continue;
//                n = 0;
//                for (int j = 0; j < matrix.Cols; j++)
//                {
//                    if (j == iCol)
//                        continue;
//                    minor[m, n] = matrix[i, j];
//                    n++;
//                }
//                m++;
//            }
//            return minor;
//        }
//        public Matrix Adjoint(Matrix Ma)
//        {
//            if (Ma.Rows != Ma.Cols)
//                throw new MatrixException("Adjoint of a non-square matrix does not exists");
//            Matrix AdjointMatrix = new Matrix(Ma.Rows, Ma.Cols);
//            for (int i = 0; i < Ma.Rows; i++)
//                for (int j = 0; j < Ma.Cols; j++)
//                    AdjointMatrix[i, j] = Math.Pow(-1, i + j) * (Minor(Ma, i, j).Determinant());
//            AdjointMatrix = AdjointMatrix.Transpose();
//            return AdjointMatrix;
//        }


//        string alphabets;
//        bool Notdogoto;


//        private void radioButtonCombo_Click(object sender, EventArgs e)
//        {
//            textBoxCharToCipher.Enabled = false;
//            comboBox1.Enabled = true;
//        }

//        private void radioButtonCustom_Click(object sender, EventArgs e)
//        {
//            textBoxCharToCipher.Enabled = true;
//            comboBox1.Enabled = false;
//        }

//        private void buttonClear_Click(object sender, EventArgs e)
//        {
//            textBoxFirstValue.Clear();
//            textBoxPlanText.Clear();
//            textBoxDecipherText.Clear();
//            textBoxCipherText.Clear();
//            textBoxCharToCipher.Clear();
//        }
//        Bluebit.MatrixLibrary.Matrix KeyMatrix;
//        Bluebit.MatrixLibrary.Matrix InverseKeyMatrix;
//        Bluebit.MatrixLibrary.Matrix PlanMatrix;
//        Bluebit.MatrixLibrary.Matrix CipherMatrix;
//        Bluebit.MatrixLibrary.Matrix DecipherMatrix;


//        private void buttonCipher_Click(object sender, EventArgs e)
//        {
//            if (textBoxPlanText.Text != string.Empty)
//            {
//                textBoxCipherText.Clear();
//                string PlanText = textBoxPlanText.Text.ToUpper();
//                if (radioButton1T.Checked)
//                {
//                    if (textBox1C.Text != "")
//                        KeyMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { Convert.ToInt32(textBox1N.Text) } });
//                    else
//                    {
//                        MessageBox.Show("أحد حقول المفتاح فارغ");
//                        return;
//                    }
//                }
//                if (radioButton2T.Checked)
//                    if (textBox1C.Text != "" && textBox2C.Text != "" && textBox8C.Text != "" && textBox9C.Text != "")
//                        KeyMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { Convert.ToInt32(textBox1N.Text), Convert.ToInt32(textBox2N.Text) }, { Convert.ToInt32(textBox8N.Text), Convert.ToInt32(textBox9N.Text) } });
//                    else
//                    {
//                        MessageBox.Show("أحد حقول المفتاح فارغ");
//                        return;
//                    }
//                if (radioButton3T.Checked)
//                    if (textBox1C.Text != "" && textBox2C.Text != "" && textBox3C.Text != "" && textBox8C.Text != "" && textBox9C.Text != "" && textBox10C.Text != "" && textBox15C.Text != "" && textBox16C.Text != "" && textBox17C.Text != "")
//                        KeyMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { Convert.ToInt32(textBox1N.Text), Convert.ToInt32(textBox2N.Text), Convert.ToInt32(textBox3N.Text) }, { Convert.ToInt32(textBox8N.Text), Convert.ToInt32(textBox9N.Text), Convert.ToInt32(textBox10N.Text) }, { Convert.ToInt32(textBox15N.Text), Convert.ToInt32(textBox16N.Text), Convert.ToInt32(textBox17N.Text) } });
//                    else
//                    {
//                        MessageBox.Show("أحد حقول المفتاح فارغ");
//                        return;
//                    }
//                if (radioButton4T.Checked)
//                    if (textBox1C.Text != "" && textBox2C.Text != "" && textBox3C.Text != "" && textBox4C.Text != "" && textBox8C.Text != "" && textBox9C.Text != "" && textBox10C.Text != "" && textBox11C.Text != "" && textBox15C.Text != "" && textBox16C.Text != "" && textBox17C.Text != "" && textBox18C.Text != "" && textBox22C.Text != "" && textBox23C.Text != "" && textBox24C.Text != "" && textBox25C.Text != "")
//                        KeyMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { Convert.ToInt32(textBox1N.Text), Convert.ToInt32(textBox2N.Text), Convert.ToInt32(textBox3N.Text), Convert.ToInt32(textBox4N.Text) }, { Convert.ToInt32(textBox8N.Text), Convert.ToInt32(textBox9N.Text), Convert.ToInt32(textBox10N.Text), Convert.ToInt32(textBox11N.Text) }, { Convert.ToInt32(textBox15N.Text), Convert.ToInt32(textBox16N.Text), Convert.ToInt32(textBox17N.Text), Convert.ToInt32(textBox18N.Text) }, { Convert.ToInt32(textBox22N.Text), Convert.ToInt32(textBox23N.Text), Convert.ToInt32(textBox24N.Text), Convert.ToInt32(textBox25N.Text) } });
//                    else
//                    {
//                        MessageBox.Show("أحد حقول المفتاح فارغ");
//                        return;
//                    }
//                if (radioButton5T.Checked)
//                    if (textBox1C.Text != "" && textBox2C.Text != "" && textBox3C.Text != "" && textBox4C.Text != "" && textBox5C.Text != "" && textBox8C.Text != "" && textBox9C.Text != "" && textBox10C.Text != "" && textBox11C.Text != "" && textBox12C.Text != "" && textBox15C.Text != "" && textBox16C.Text != "" && textBox17C.Text != "" && textBox18C.Text != "" && textBox19C.Text != "" && textBox22C.Text != "" && textBox23C.Text != "" && textBox24C.Text != "" && textBox25C.Text != "" && textBox26C.Text != "" && textBox29C.Text != "" && textBox30C.Text != "" && textBox31C.Text != "" && textBox32C.Text != "" && textBox33C.Text != "")
//                        KeyMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { Convert.ToInt32(textBox1N.Text), Convert.ToInt32(textBox2N.Text), Convert.ToInt32(textBox3N.Text), Convert.ToInt32(textBox4N.Text), Convert.ToInt32(textBox5N.Text) }, { Convert.ToInt32(textBox8N.Text), Convert.ToInt32(textBox9N.Text), Convert.ToInt32(textBox10N.Text), Convert.ToInt32(textBox11N.Text), Convert.ToInt32(textBox12N.Text) }, { Convert.ToInt32(textBox15N.Text), Convert.ToInt32(textBox16N.Text), Convert.ToInt32(textBox17N.Text), Convert.ToInt32(textBox18N.Text), Convert.ToInt32(textBox19N.Text) }, { Convert.ToInt32(textBox22N.Text), Convert.ToInt32(textBox23N.Text), Convert.ToInt32(textBox24N.Text), Convert.ToInt32(textBox25N.Text), Convert.ToInt32(textBox26N.Text) }, { Convert.ToInt32(textBox29N.Text), Convert.ToInt32(textBox30N.Text), Convert.ToInt32(textBox31N.Text), Convert.ToInt32(textBox32N.Text), Convert.ToInt32(textBox33N.Text) } });
//                    else
//                    {
//                        MessageBox.Show("أحد حقول المفتاح فارغ");
//                        return;
//                    }
//                if (radioButton6T.Checked)
//                    if (textBox1C.Text != "" && textBox2C.Text != "" && textBox3C.Text != "" && textBox4C.Text != "" && textBox5C.Text != "" && textBox6C.Text != "" && textBox8C.Text != "" && textBox9C.Text != "" && textBox10C.Text != "" && textBox11C.Text != "" && textBox12C.Text != "" && textBox13C.Text != "" && textBox15C.Text != "" && textBox16C.Text != "" && textBox17C.Text != "" && textBox18C.Text != "" && textBox19C.Text != "" && textBox20C.Text != "" && textBox22C.Text != "" && textBox23C.Text != "" && textBox24C.Text != "" && textBox25C.Text != "" && textBox26C.Text != "" && textBox27C.Text != "" && textBox29C.Text != "" && textBox30C.Text != "" && textBox31C.Text != "" && textBox32C.Text != "" && textBox33C.Text != "" && textBox34C.Text != "" && textBox36C.Text != "" && textBox37C.Text != "" && textBox38C.Text != "" && textBox39C.Text != "" && textBox40C.Text != "" && textBox41C.Text != "")
//                        KeyMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { Convert.ToInt32(textBox1N.Text), Convert.ToInt32(textBox2N.Text), Convert.ToInt32(textBox3N.Text), Convert.ToInt32(textBox4N.Text), Convert.ToInt32(textBox5N.Text), Convert.ToInt32(textBox6N.Text) }, { Convert.ToInt32(textBox8N.Text), Convert.ToInt32(textBox9N.Text), Convert.ToInt32(textBox10N.Text), Convert.ToInt32(textBox11N.Text), Convert.ToInt32(textBox12N.Text), Convert.ToInt32(textBox13N.Text) }, { Convert.ToInt32(textBox15N.Text), Convert.ToInt32(textBox16N.Text), Convert.ToInt32(textBox17N.Text), Convert.ToInt32(textBox18N.Text), Convert.ToInt32(textBox19N.Text), Convert.ToInt32(textBox20N.Text) }, { Convert.ToInt32(textBox22N.Text), Convert.ToInt32(textBox23N.Text), Convert.ToInt32(textBox24N.Text), Convert.ToInt32(textBox25N.Text), Convert.ToInt32(textBox26N.Text), Convert.ToInt32(textBox27N.Text) }, { Convert.ToInt32(textBox29N.Text), Convert.ToInt32(textBox30N.Text), Convert.ToInt32(textBox31N.Text), Convert.ToInt32(textBox32N.Text), Convert.ToInt32(textBox33N.Text), Convert.ToInt32(textBox34N.Text) }, { Convert.ToInt32(textBox36N.Text), Convert.ToInt32(textBox37N.Text), Convert.ToInt32(textBox38N.Text), Convert.ToInt32(textBox39N.Text), Convert.ToInt32(textBox40N.Text), Convert.ToInt32(textBox41N.Text) } });
//                    else
//                    {
//                        MessageBox.Show("أحد حقول المفتاح فارغ");
//                        return;
//                    }
//                if (radioButton7T.Checked)
//                    if (textBox1C.Text != "" && textBox2C.Text != "" && textBox3C.Text != "" && textBox4C.Text != "" && textBox5C.Text != "" && textBox6C.Text != "" && textBox7C.Text != "" && textBox8C.Text != "" && textBox9C.Text != "" && textBox10C.Text != "" && textBox11C.Text != "" && textBox12C.Text != "" && textBox13C.Text != "" && textBox14C.Text != "" && textBox15C.Text != "" && textBox16C.Text != "" && textBox17C.Text != "" && textBox18C.Text != "" && textBox19C.Text != "" && textBox20C.Text != "" && textBox21C.Text != "" && textBox22C.Text != "" && textBox23C.Text != "" && textBox24C.Text != "" && textBox25C.Text != "" && textBox26C.Text != "" && textBox27C.Text != "" && textBox28C.Text != "" && textBox29C.Text != "" && textBox30C.Text != "" && textBox31C.Text != "" && textBox32C.Text != "" && textBox33C.Text != "" && textBox34C.Text != "" && textBox35C.Text != "" && textBox36C.Text != "" && textBox37C.Text != "" && textBox38C.Text != "" && textBox39C.Text != "" && textBox40C.Text != "" && textBox41C.Text != "" && textBox42C.Text != "" && textBox43C.Text != "" && textBox44C.Text != "" && textBox45C.Text != "" && textBox46C.Text != "" && textBox47C.Text != "" && textBox48C.Text != "" && textBox49C.Text != "")
//                        KeyMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { Convert.ToInt32(textBox1N.Text), Convert.ToInt32(textBox2N.Text), Convert.ToInt32(textBox3N.Text), Convert.ToInt32(textBox4N.Text), Convert.ToInt32(textBox5N.Text), Convert.ToInt32(textBox6N.Text), Convert.ToInt32(textBox7N.Text) }, { Convert.ToInt32(textBox8N.Text), Convert.ToInt32(textBox9N.Text), Convert.ToInt32(textBox10N.Text), Convert.ToInt32(textBox11N.Text), Convert.ToInt32(textBox12N.Text), Convert.ToInt32(textBox13N.Text), Convert.ToInt32(textBox14N.Text) }, { Convert.ToInt32(textBox15N.Text), Convert.ToInt32(textBox16N.Text), Convert.ToInt32(textBox17N.Text), Convert.ToInt32(textBox18N.Text), Convert.ToInt32(textBox19N.Text), Convert.ToInt32(textBox20N.Text), Convert.ToInt32(textBox21N.Text) }, { Convert.ToInt32(textBox22N.Text), Convert.ToInt32(textBox23N.Text), Convert.ToInt32(textBox24N.Text), Convert.ToInt32(textBox25N.Text), Convert.ToInt32(textBox26N.Text), Convert.ToInt32(textBox27N.Text), Convert.ToInt32(textBox28N.Text) }, { Convert.ToInt32(textBox29N.Text), Convert.ToInt32(textBox30N.Text), Convert.ToInt32(textBox31N.Text), Convert.ToInt32(textBox32N.Text), Convert.ToInt32(textBox33N.Text), Convert.ToInt32(textBox34N.Text), Convert.ToInt32(textBox35N.Text) }, { Convert.ToInt32(textBox36N.Text), Convert.ToInt32(textBox37N.Text), Convert.ToInt32(textBox38N.Text), Convert.ToInt32(textBox39N.Text), Convert.ToInt32(textBox40N.Text), Convert.ToInt32(textBox41N.Text), Convert.ToInt32(textBox42N.Text) }, { Convert.ToInt32(textBox43N.Text), Convert.ToInt32(textBox44N.Text), Convert.ToInt32(textBox45N.Text), Convert.ToInt32(textBox46N.Text), Convert.ToInt32(textBox47N.Text), Convert.ToInt32(textBox48N.Text), Convert.ToInt32(textBox49N.Text) } });
//                    else
//                    {
//                        MessageBox.Show("أحد حقول المفتاح فارغ");
//                        return;
//                    }
//                ////////////////////////////////////////////////////////////تم تعبئة المفتاح في مصفوفة اسمها كي ماتركس

//                ///////////////////////////////////////////////////////////سنقوم بالتحقق من قبول المفتاح لاستخراج مصفوفة المقلوب
//                Notdogoto = false;
//                int det = (int)KeyMatrix.Determinant();
//                if (det == 0)
//                    goto ErorrKey;
//                int detmod = Mod(det, alphabets.Length);
//                if (detmod == 0)
//                    goto ErorrKey;
//                int x = 0;
//                if (GCD(alphabets.Length, detmod) != 1)
//                    goto ErorrKey;
//                for (int i = 1; i < alphabets.Length; i++)
//                {
//                    if (Mod(detmod * i, alphabets.Length) == 1)
//                    {
//                        x = i;
//                        break;
//                    }
//                }

//                //Matrix Adj = Adjoint(KeyMatrix);
//                Matrix Adj = Matrix.Multiply(KeyMatrix.Inverse(), KeyMatrix.Determinant());
//                Matrix Adjx = Matrix.Multiply(Adj, x);


//                Matrix Adjxmod = new Matrix();
//                if (radioButton1T.Checked)
//                {
//                    Adjxmod = new Matrix(1, 1);
//                    Adjxmod[0, 0] = Mod(Convert.ToInt32(Adjx[0, 0]), alphabets.Length);
//                }
//                if (radioButton2T.Checked)
//                {
//                    Adjxmod = new Matrix(2, 2);
//                    Adjxmod[0, 0] = Mod(Convert.ToInt32(Adjx[0, 0]), alphabets.Length); Adjxmod[0, 1] = Mod(Convert.ToInt32(Adjx[0, 1]), alphabets.Length);
//                    Adjxmod[1, 0] = Mod(Convert.ToInt32(Adjx[1, 0]), alphabets.Length); Adjxmod[1, 1] = Mod(Convert.ToInt32(Adjx[1, 1]), alphabets.Length);
//                }
//                if (radioButton3T.Checked)
//                {
//                    Adjxmod = new Matrix(3, 3);
//                    Adjxmod[0, 0] = Mod(Convert.ToInt32(Adjx[0, 0]), alphabets.Length); Adjxmod[0, 1] = Mod(Convert.ToInt32(Adjx[0, 1]), alphabets.Length); Adjxmod[0, 2] = Mod(Convert.ToInt32(Adjx[0, 2]), alphabets.Length);
//                    Adjxmod[1, 0] = Mod(Convert.ToInt32(Adjx[1, 0]), alphabets.Length); Adjxmod[1, 1] = Mod(Convert.ToInt32(Adjx[1, 1]), alphabets.Length); Adjxmod[1, 2] = Mod(Convert.ToInt32(Adjx[1, 2]), alphabets.Length);
//                    Adjxmod[2, 0] = Mod(Convert.ToInt32(Adjx[2, 0]), alphabets.Length); Adjxmod[2, 1] = Mod(Convert.ToInt32(Adjx[2, 1]), alphabets.Length); Adjxmod[2, 2] = Mod(Convert.ToInt32(Adjx[2, 2]), alphabets.Length);
//                }
//                if (radioButton4T.Checked)
//                {
//                    Adjxmod = new Matrix(4, 4);
//                    Adjxmod[0, 0] = Mod(Convert.ToInt32(Adjx[0, 0]), alphabets.Length); Adjxmod[0, 1] = Mod(Convert.ToInt32(Adjx[0, 1]), alphabets.Length); Adjxmod[0, 2] = Mod(Convert.ToInt32(Adjx[0, 2]), alphabets.Length); Adjxmod[0, 3] = Mod(Convert.ToInt32(Adjx[0, 3]), alphabets.Length);
//                    Adjxmod[1, 0] = Mod(Convert.ToInt32(Adjx[1, 0]), alphabets.Length); Adjxmod[1, 1] = Mod(Convert.ToInt32(Adjx[1, 1]), alphabets.Length); Adjxmod[1, 2] = Mod(Convert.ToInt32(Adjx[1, 2]), alphabets.Length); Adjxmod[1, 3] = Mod(Convert.ToInt32(Adjx[1, 3]), alphabets.Length);
//                    Adjxmod[2, 0] = Mod(Convert.ToInt32(Adjx[2, 0]), alphabets.Length); Adjxmod[2, 1] = Mod(Convert.ToInt32(Adjx[2, 1]), alphabets.Length); Adjxmod[2, 2] = Mod(Convert.ToInt32(Adjx[2, 2]), alphabets.Length); Adjxmod[2, 3] = Mod(Convert.ToInt32(Adjx[2, 3]), alphabets.Length);
//                    Adjxmod[3, 0] = Mod(Convert.ToInt32(Adjx[3, 0]), alphabets.Length); Adjxmod[3, 1] = Mod(Convert.ToInt32(Adjx[3, 1]), alphabets.Length); Adjxmod[3, 2] = Mod(Convert.ToInt32(Adjx[3, 2]), alphabets.Length); Adjxmod[3, 3] = Mod(Convert.ToInt32(Adjx[3, 3]), alphabets.Length);
//                }
//                if (radioButton5T.Checked)
//                {
//                    Adjxmod = new Matrix(5, 5);
//                    Adjxmod[0, 0] = Mod(Convert.ToInt32(Adjx[0, 0]), alphabets.Length); Adjxmod[0, 1] = Mod(Convert.ToInt32(Adjx[0, 1]), alphabets.Length); Adjxmod[0, 2] = Mod(Convert.ToInt32(Adjx[0, 2]), alphabets.Length); Adjxmod[0, 3] = Mod(Convert.ToInt32(Adjx[0, 3]), alphabets.Length); Adjxmod[0, 4] = Mod(Convert.ToInt32(Adjx[0, 4]), alphabets.Length);
//                    Adjxmod[1, 0] = Mod(Convert.ToInt32(Adjx[1, 0]), alphabets.Length); Adjxmod[1, 1] = Mod(Convert.ToInt32(Adjx[1, 1]), alphabets.Length); Adjxmod[1, 2] = Mod(Convert.ToInt32(Adjx[1, 2]), alphabets.Length); Adjxmod[1, 3] = Mod(Convert.ToInt32(Adjx[1, 3]), alphabets.Length); Adjxmod[1, 4] = Mod(Convert.ToInt32(Adjx[1, 4]), alphabets.Length);
//                    Adjxmod[2, 0] = Mod(Convert.ToInt32(Adjx[2, 0]), alphabets.Length); Adjxmod[2, 1] = Mod(Convert.ToInt32(Adjx[2, 1]), alphabets.Length); Adjxmod[2, 2] = Mod(Convert.ToInt32(Adjx[2, 2]), alphabets.Length); Adjxmod[2, 3] = Mod(Convert.ToInt32(Adjx[2, 3]), alphabets.Length); Adjxmod[2, 4] = Mod(Convert.ToInt32(Adjx[2, 4]), alphabets.Length);
//                    Adjxmod[3, 0] = Mod(Convert.ToInt32(Adjx[3, 0]), alphabets.Length); Adjxmod[3, 1] = Mod(Convert.ToInt32(Adjx[3, 1]), alphabets.Length); Adjxmod[3, 2] = Mod(Convert.ToInt32(Adjx[3, 2]), alphabets.Length); Adjxmod[3, 3] = Mod(Convert.ToInt32(Adjx[3, 3]), alphabets.Length); Adjxmod[3, 4] = Mod(Convert.ToInt32(Adjx[3, 4]), alphabets.Length);
//                    Adjxmod[4, 0] = Mod(Convert.ToInt32(Adjx[4, 0]), alphabets.Length); Adjxmod[4, 1] = Mod(Convert.ToInt32(Adjx[4, 1]), alphabets.Length); Adjxmod[4, 2] = Mod(Convert.ToInt32(Adjx[4, 2]), alphabets.Length); Adjxmod[4, 3] = Mod(Convert.ToInt32(Adjx[4, 3]), alphabets.Length); Adjxmod[4, 4] = Mod(Convert.ToInt32(Adjx[4, 4]), alphabets.Length);
//                }
//                if (radioButton6T.Checked)
//                {
//                    Adjxmod = new Matrix(6, 6);
//                    Adjxmod[0, 0] = Mod(Convert.ToInt32(Adjx[0, 0]), alphabets.Length); Adjxmod[0, 1] = Mod(Convert.ToInt32(Adjx[0, 1]), alphabets.Length); Adjxmod[0, 2] = Mod(Convert.ToInt32(Adjx[0, 2]), alphabets.Length); Adjxmod[0, 3] = Mod(Convert.ToInt32(Adjx[0, 3]), alphabets.Length); Adjxmod[0, 4] = Mod(Convert.ToInt32(Adjx[0, 4]), alphabets.Length); Adjxmod[0, 5] = Mod(Convert.ToInt32(Adjx[0, 5]), alphabets.Length);
//                    Adjxmod[1, 0] = Mod(Convert.ToInt32(Adjx[1, 0]), alphabets.Length); Adjxmod[1, 1] = Mod(Convert.ToInt32(Adjx[1, 1]), alphabets.Length); Adjxmod[1, 2] = Mod(Convert.ToInt32(Adjx[1, 2]), alphabets.Length); Adjxmod[1, 3] = Mod(Convert.ToInt32(Adjx[1, 3]), alphabets.Length); Adjxmod[1, 4] = Mod(Convert.ToInt32(Adjx[1, 4]), alphabets.Length); Adjxmod[1, 5] = Mod(Convert.ToInt32(Adjx[1, 5]), alphabets.Length);
//                    Adjxmod[2, 0] = Mod(Convert.ToInt32(Adjx[2, 0]), alphabets.Length); Adjxmod[2, 1] = Mod(Convert.ToInt32(Adjx[2, 1]), alphabets.Length); Adjxmod[2, 2] = Mod(Convert.ToInt32(Adjx[2, 2]), alphabets.Length); Adjxmod[2, 3] = Mod(Convert.ToInt32(Adjx[2, 3]), alphabets.Length); Adjxmod[2, 4] = Mod(Convert.ToInt32(Adjx[2, 4]), alphabets.Length); Adjxmod[2, 5] = Mod(Convert.ToInt32(Adjx[2, 5]), alphabets.Length);
//                    Adjxmod[3, 0] = Mod(Convert.ToInt32(Adjx[3, 0]), alphabets.Length); Adjxmod[3, 1] = Mod(Convert.ToInt32(Adjx[3, 1]), alphabets.Length); Adjxmod[3, 2] = Mod(Convert.ToInt32(Adjx[3, 2]), alphabets.Length); Adjxmod[3, 3] = Mod(Convert.ToInt32(Adjx[3, 3]), alphabets.Length); Adjxmod[3, 4] = Mod(Convert.ToInt32(Adjx[3, 4]), alphabets.Length); Adjxmod[3, 5] = Mod(Convert.ToInt32(Adjx[3, 5]), alphabets.Length);
//                    Adjxmod[4, 0] = Mod(Convert.ToInt32(Adjx[4, 0]), alphabets.Length); Adjxmod[4, 1] = Mod(Convert.ToInt32(Adjx[4, 1]), alphabets.Length); Adjxmod[4, 2] = Mod(Convert.ToInt32(Adjx[4, 2]), alphabets.Length); Adjxmod[4, 3] = Mod(Convert.ToInt32(Adjx[4, 3]), alphabets.Length); Adjxmod[4, 4] = Mod(Convert.ToInt32(Adjx[4, 4]), alphabets.Length); Adjxmod[4, 5] = Mod(Convert.ToInt32(Adjx[4, 5]), alphabets.Length);
//                    Adjxmod[5, 0] = Mod(Convert.ToInt32(Adjx[5, 0]), alphabets.Length); Adjxmod[5, 1] = Mod(Convert.ToInt32(Adjx[5, 1]), alphabets.Length); Adjxmod[5, 2] = Mod(Convert.ToInt32(Adjx[5, 2]), alphabets.Length); Adjxmod[5, 3] = Mod(Convert.ToInt32(Adjx[5, 3]), alphabets.Length); Adjxmod[5, 4] = Mod(Convert.ToInt32(Adjx[5, 4]), alphabets.Length); Adjxmod[5, 5] = Mod(Convert.ToInt32(Adjx[5, 5]), alphabets.Length);
//                }
//                if (radioButton7T.Checked)
//                {
//                    Adjxmod = new Matrix(7, 7);
//                    Adjxmod[0, 0] = Mod(Convert.ToInt32(Adjx[0, 0]), alphabets.Length); Adjxmod[0, 1] = Mod(Convert.ToInt32(Adjx[0, 1]), alphabets.Length); Adjxmod[0, 2] = Mod(Convert.ToInt32(Adjx[0, 2]), alphabets.Length); Adjxmod[0, 3] = Mod(Convert.ToInt32(Adjx[0, 3]), alphabets.Length); Adjxmod[0, 4] = Mod(Convert.ToInt32(Adjx[0, 4]), alphabets.Length); Adjxmod[0, 5] = Mod(Convert.ToInt32(Adjx[0, 5]), alphabets.Length); Adjxmod[0, 6] = Mod(Convert.ToInt32(Adjx[0, 6]), alphabets.Length);
//                    Adjxmod[1, 0] = Mod(Convert.ToInt32(Adjx[1, 0]), alphabets.Length); Adjxmod[1, 1] = Mod(Convert.ToInt32(Adjx[1, 1]), alphabets.Length); Adjxmod[1, 2] = Mod(Convert.ToInt32(Adjx[1, 2]), alphabets.Length); Adjxmod[1, 3] = Mod(Convert.ToInt32(Adjx[1, 3]), alphabets.Length); Adjxmod[1, 4] = Mod(Convert.ToInt32(Adjx[1, 4]), alphabets.Length); Adjxmod[1, 5] = Mod(Convert.ToInt32(Adjx[1, 5]), alphabets.Length); Adjxmod[1, 6] = Mod(Convert.ToInt32(Adjx[1, 6]), alphabets.Length);
//                    Adjxmod[2, 0] = Mod(Convert.ToInt32(Adjx[2, 0]), alphabets.Length); Adjxmod[2, 1] = Mod(Convert.ToInt32(Adjx[2, 1]), alphabets.Length); Adjxmod[2, 2] = Mod(Convert.ToInt32(Adjx[2, 2]), alphabets.Length); Adjxmod[2, 3] = Mod(Convert.ToInt32(Adjx[2, 3]), alphabets.Length); Adjxmod[2, 4] = Mod(Convert.ToInt32(Adjx[2, 4]), alphabets.Length); Adjxmod[2, 5] = Mod(Convert.ToInt32(Adjx[2, 5]), alphabets.Length); Adjxmod[2, 6] = Mod(Convert.ToInt32(Adjx[2, 6]), alphabets.Length);
//                    Adjxmod[3, 0] = Mod(Convert.ToInt32(Adjx[3, 0]), alphabets.Length); Adjxmod[3, 1] = Mod(Convert.ToInt32(Adjx[3, 1]), alphabets.Length); Adjxmod[3, 2] = Mod(Convert.ToInt32(Adjx[3, 2]), alphabets.Length); Adjxmod[3, 3] = Mod(Convert.ToInt32(Adjx[3, 3]), alphabets.Length); Adjxmod[3, 4] = Mod(Convert.ToInt32(Adjx[3, 4]), alphabets.Length); Adjxmod[3, 5] = Mod(Convert.ToInt32(Adjx[3, 5]), alphabets.Length); Adjxmod[3, 6] = Mod(Convert.ToInt32(Adjx[3, 6]), alphabets.Length);
//                    Adjxmod[4, 0] = Mod(Convert.ToInt32(Adjx[4, 0]), alphabets.Length); Adjxmod[4, 1] = Mod(Convert.ToInt32(Adjx[4, 1]), alphabets.Length); Adjxmod[4, 2] = Mod(Convert.ToInt32(Adjx[4, 2]), alphabets.Length); Adjxmod[4, 3] = Mod(Convert.ToInt32(Adjx[4, 3]), alphabets.Length); Adjxmod[4, 4] = Mod(Convert.ToInt32(Adjx[4, 4]), alphabets.Length); Adjxmod[4, 5] = Mod(Convert.ToInt32(Adjx[4, 5]), alphabets.Length); Adjxmod[4, 6] = Mod(Convert.ToInt32(Adjx[4, 6]), alphabets.Length);
//                    Adjxmod[5, 0] = Mod(Convert.ToInt32(Adjx[5, 0]), alphabets.Length); Adjxmod[5, 1] = Mod(Convert.ToInt32(Adjx[5, 1]), alphabets.Length); Adjxmod[5, 2] = Mod(Convert.ToInt32(Adjx[5, 2]), alphabets.Length); Adjxmod[5, 3] = Mod(Convert.ToInt32(Adjx[5, 3]), alphabets.Length); Adjxmod[5, 4] = Mod(Convert.ToInt32(Adjx[5, 4]), alphabets.Length); Adjxmod[5, 5] = Mod(Convert.ToInt32(Adjx[5, 5]), alphabets.Length); Adjxmod[5, 6] = Mod(Convert.ToInt32(Adjx[5, 6]), alphabets.Length);
//                    Adjxmod[6, 0] = Mod(Convert.ToInt32(Adjx[6, 0]), alphabets.Length); Adjxmod[6, 1] = Mod(Convert.ToInt32(Adjx[6, 1]), alphabets.Length); Adjxmod[6, 2] = Mod(Convert.ToInt32(Adjx[6, 2]), alphabets.Length); Adjxmod[6, 3] = Mod(Convert.ToInt32(Adjx[6, 3]), alphabets.Length); Adjxmod[6, 4] = Mod(Convert.ToInt32(Adjx[6, 4]), alphabets.Length); Adjxmod[6, 5] = Mod(Convert.ToInt32(Adjx[6, 5]), alphabets.Length); Adjxmod[6, 6] = Mod(Convert.ToInt32(Adjx[6, 6]), alphabets.Length);
//                }
//                InverseKeyMatrix = Adjxmod;
//                Notdogoto = true;
//                //////////////////////////////////////////////////////////سنقوم باستخراج النص مفكوك التشفير
//                if (radioButton1T.Checked)
//                    for (int i = 0; i < PlanText.Length; i++)
//                    {
//                        if (alphabets.Contains(PlanText[i]))
//                        {
//                            PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) } });
//                            CipherMatrix = Matrix.Multiply(KeyMatrix, PlanMatrix);
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxCipherText.Text += PlanText[i].ToString();
//                        }
//                    }

//                if (radioButton2T.Checked)
//                {
//                    bool alone = true;

//                    for (int i = 0; i < PlanText.Length; i += 2)
//                    {
//                        string B1 = "";
//                        int f = 0;
//                        alone = true;
//                        if (alphabets.Contains(PlanText[i]))
//                        {
//                            for (int j = i + 1; j < PlanText.Length; j++)
//                            {
//                                if (alphabets.Contains(PlanText[j]))
//                                {
//                                    PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[j]) } });
//                                    alone = false;
//                                    break;
//                                }
//                                else
//                                {
//                                    B1 += PlanText[j];
//                                    f++;
//                                }
//                            }
//                            if (alone == true)
//                            {
//                                PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { 0 } });
//                            }
//                            i += f;
//                            CipherMatrix = Matrix.Multiply(KeyMatrix, PlanMatrix);
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B1;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[1, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxCipherText.Text += PlanText[i].ToString();
//                            i--;
//                        }
//                    }
//                }

//                if (radioButton3T.Checked)
//                {
//                    for (int i = 0; i < PlanText.Length; i += 3)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int outerj = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        if (alphabets.Contains(PlanText[i]))
//                        {
//                            for (int j = i + 1; j < PlanText.Length; j++)
//                            {
//                                if (alphabets.Contains(PlanText[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < PlanText.Length; k++)
//                                    {
//                                        if (alphabets.Contains(PlanText[k]))
//                                        {
//                                            PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[j]) }, { alphabets.IndexOf(PlanText[k]) } });
//                                            alone2 = false;
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += PlanText[k];
//                                            f2++;
//                                        }
//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += PlanText[j];
//                                    f1++;
//                                }
//                            }
//                        Tor:
//                            if (alone1 == true)
//                            {
//                                PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { 0 }, { 0 } });
//                            }
//                            else
//                                if (alone2 == true)
//                                {
//                                    PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { 0 } });
//                                }
//                            i += f1 + f2;
//                            CipherMatrix = Matrix.Multiply(KeyMatrix, PlanMatrix);
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B1;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B2;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[2, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxCipherText.Text += PlanText[i].ToString();
//                            i -= 2;
//                        }
//                    }
//                }

//                if (radioButton4T.Checked)
//                {
//                    for (int i = 0; i < PlanText.Length; i += 4)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        string B3 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int f3 = 0;
//                        int outerj = 0;
//                        int outerk = 0;
//                        //int outerh = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        bool alone3 = true;

//                        if (alphabets.Contains(PlanText[i]))
//                        {
//                            for (int j = i + 1; j < PlanText.Length; j++)
//                            {
//                                if (alphabets.Contains(PlanText[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < PlanText.Length; k++)
//                                    {
//                                        if (alphabets.Contains(PlanText[k]))
//                                        {
//                                            outerk = k;
//                                            alone2 = false;
//                                            for (int h = k + 1; h < PlanText.Length; h++)
//                                            {
//                                                if (alphabets.Contains(PlanText[h]))
//                                                {
//                                                    PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[j]) }, { alphabets.IndexOf(PlanText[k]) }, { alphabets.IndexOf(PlanText[h]) } });
//                                                    alone3 = false;
//                                                    goto Tor;
//                                                }
//                                                else
//                                                {
//                                                    B3 += PlanText[h];
//                                                    f3++;
//                                                }
//                                            }
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += PlanText[k];
//                                            f2++;
//                                        }

//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += PlanText[j];
//                                    f1++;
//                                }
//                            }
//                        Tor:
//                            if (alone1 == true)
//                                PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { 0 }, { 0 }, { 0 } });
//                            else
//                                if (alone2 == true)
//                                    PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { 0 }, { 0 } });
//                                else
//                                    if (alone3 == true)
//                                        PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { 0 } });

//                            i += f1 + f2 + f3;
//                            CipherMatrix = Matrix.Multiply(KeyMatrix, PlanMatrix);
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B1;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B2;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[2, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B3;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[3, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxCipherText.Text += PlanText[i].ToString();
//                            i -= 3;
//                        }
//                    }
//                }

//                if (radioButton5T.Checked)
//                {
//                    for (int i = 0; i < PlanText.Length; i += 5)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        string B3 = "";
//                        string B4 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int f3 = 0;
//                        int f4 = 0;
//                        int outerj = 0;
//                        int outerk = 0;
//                        int outerh = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        bool alone3 = true;
//                        bool alone4 = true;

//                        if (alphabets.Contains(PlanText[i]))
//                        {
//                            for (int j = i + 1; j < PlanText.Length; j++)
//                            {
//                                if (alphabets.Contains(PlanText[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < PlanText.Length; k++)
//                                    {
//                                        if (alphabets.Contains(PlanText[k]))
//                                        {
//                                            outerk = k;
//                                            alone2 = false;
//                                            for (int h = k + 1; h < PlanText.Length; h++)
//                                            {
//                                                if (alphabets.Contains(PlanText[h]))
//                                                {
//                                                    outerh = h;
//                                                    alone3 = false;
//                                                    for (int g = h + 1; g < PlanText.Length; g++)
//                                                    {
//                                                        if (alphabets.Contains(PlanText[g]))
//                                                        {
//                                                            PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[j]) }, { alphabets.IndexOf(PlanText[k]) }, { alphabets.IndexOf(PlanText[h]) }, { alphabets.IndexOf(PlanText[g]) } });
//                                                            alone4 = false;
//                                                            goto Tor;
//                                                        }
//                                                        else
//                                                        {
//                                                            B4 += PlanText[g];
//                                                            f4++;
//                                                        }
//                                                    }
//                                                    goto Tor;
//                                                }
//                                                else
//                                                {
//                                                    B3 += PlanText[h];
//                                                    f3++;
//                                                }
//                                            }
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += PlanText[k];
//                                            f2++;
//                                        }

//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += PlanText[j];
//                                    f1++;
//                                }
//                            }
//                        Tor:
//                            if (alone1 == true)
//                            {
//                                PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { 0 }, { 0 }, { 0 }, { 0 } });
//                            }
//                            else
//                                if (alone2 == true)
//                                {
//                                    PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { 0 }, { 0 }, { 0 } });
//                                }
//                                else
//                                    if (alone3 == true)
//                                        PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { 0 }, { 0 } });
//                                    else
//                                        if (alone4 == true)
//                                            PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { alphabets.IndexOf(PlanText[outerh]) }, { 0 } });

//                            i += f1 + f2 + f3 + f4;
//                            CipherMatrix = Matrix.Multiply(KeyMatrix, PlanMatrix);
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B1;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B2;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[2, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B3;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[3, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B4;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[4, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxCipherText.Text += PlanText[i].ToString();
//                            i -= 4;
//                        }
//                    }
//                }

//                if (radioButton6T.Checked)
//                {
//                    for (int i = 0; i < PlanText.Length; i += 6)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        string B3 = "";
//                        string B4 = "";
//                        string B5 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int f3 = 0;
//                        int f4 = 0;
//                        int f5 = 0;
//                        int outerj = 0;
//                        int outerk = 0;
//                        int outerh = 0;
//                        int outerg = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        bool alone3 = true;
//                        bool alone4 = true;
//                        bool alone5 = true;

//                        if (alphabets.Contains(PlanText[i]))
//                        {
//                            for (int j = i + 1; j < PlanText.Length; j++)
//                            {
//                                if (alphabets.Contains(PlanText[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < PlanText.Length; k++)
//                                    {
//                                        if (alphabets.Contains(PlanText[k]))
//                                        {
//                                            outerk = k;
//                                            alone2 = false;
//                                            for (int h = k + 1; h < PlanText.Length; h++)
//                                            {
//                                                if (alphabets.Contains(PlanText[h]))
//                                                {
//                                                    outerh = h;
//                                                    alone3 = false;
//                                                    for (int g = h + 1; g < PlanText.Length; g++)
//                                                    {
//                                                        if (alphabets.Contains(PlanText[g]))
//                                                        {
//                                                            outerg = g;
//                                                            alone4 = false;
//                                                            for (int w = g + 1; w < PlanText.Length; w++)
//                                                            {
//                                                                if (alphabets.Contains(PlanText[w]))
//                                                                {
//                                                                    PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[j]) }, { alphabets.IndexOf(PlanText[k]) }, { alphabets.IndexOf(PlanText[h]) }, { alphabets.IndexOf(PlanText[g]) }, { alphabets.IndexOf(PlanText[w]) } });
//                                                                    alone5 = false;
//                                                                    goto Tor;
//                                                                }
//                                                                else
//                                                                {
//                                                                    B5 += PlanText[w];
//                                                                    f5++;
//                                                                }
//                                                            }
//                                                            goto Tor;
//                                                        }
//                                                        else
//                                                        {
//                                                            B4 += PlanText[g];
//                                                            f4++;
//                                                        }
//                                                    }
//                                                    goto Tor;
//                                                }
//                                                else
//                                                {
//                                                    B3 += PlanText[h];
//                                                    f3++;
//                                                }
//                                            }
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += PlanText[k];
//                                            f2++;
//                                        }

//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += PlanText[j];
//                                    f1++;
//                                }

//                            }
//                        Tor:
//                            if (alone1 == true)
//                                PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } });
//                            else
//                                if (alone2 == true)
//                                    PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { 0 }, { 0 }, { 0 }, { 0 } });
//                                else
//                                    if (alone3 == true)
//                                        PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { 0 }, { 0 }, { 0 } });
//                                    else
//                                        if (alone4 == true)
//                                            PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { alphabets.IndexOf(PlanText[outerh]) }, { 0 }, { 0 } });
//                                        else
//                                            if (alone5 == true)
//                                                PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { alphabets.IndexOf(PlanText[outerh]) }, { alphabets.IndexOf(PlanText[outerg]) }, { 0 } });

//                            i += f1 + f2 + f3 + f4 + f5;
//                            CipherMatrix = Matrix.Multiply(KeyMatrix, PlanMatrix);
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B1;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B2;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[2, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B3;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[3, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B4;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[4, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B5;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[5, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxCipherText.Text += PlanText[i].ToString();
//                            i -= 5;
//                        }
//                    }
//                }

//                if (radioButton7T.Checked)
//                {
//                    for (int i = 0; i < PlanText.Length; i += 7)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        string B3 = "";
//                        string B4 = "";
//                        string B5 = "";
//                        string B6 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int f3 = 0;
//                        int f4 = 0;
//                        int f5 = 0;
//                        int f6 = 0;
//                        int outerj = 0;
//                        int outerk = 0;
//                        int outerh = 0;
//                        int outerg = 0;
//                        int outerw = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        bool alone3 = true;
//                        bool alone4 = true;
//                        bool alone5 = true;
//                        bool alone6 = true;

//                        if (alphabets.Contains(PlanText[i]))
//                        {
//                            for (int j = i + 1; j < PlanText.Length; j++)
//                            {
//                                if (alphabets.Contains(PlanText[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < PlanText.Length; k++)
//                                    {
//                                        if (alphabets.Contains(PlanText[k]))
//                                        {
//                                            outerk = k;
//                                            alone2 = false;
//                                            for (int h = k + 1; h < PlanText.Length; h++)
//                                            {
//                                                if (alphabets.Contains(PlanText[h]))
//                                                {
//                                                    outerh = h;
//                                                    alone3 = false;
//                                                    for (int g = h + 1; g < PlanText.Length; g++)
//                                                    {
//                                                        if (alphabets.Contains(PlanText[g]))
//                                                        {
//                                                            outerg = g;
//                                                            alone4 = false;
//                                                            for (int w = g + 1; w < PlanText.Length; w++)
//                                                            {
//                                                                if (alphabets.Contains(PlanText[w]))
//                                                                {
//                                                                    outerw = w;
//                                                                    alone5 = false;
//                                                                    for (int q = w + 1; q < PlanText.Length; q++)
//                                                                    {
//                                                                        if (alphabets.Contains(PlanText[q]))
//                                                                        {
//                                                                            PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[j]) }, { alphabets.IndexOf(PlanText[k]) }, { alphabets.IndexOf(PlanText[h]) }, { alphabets.IndexOf(PlanText[g]) }, { alphabets.IndexOf(PlanText[w]) }, { alphabets.IndexOf(PlanText[q]) } });
//                                                                            alone6 = false;
//                                                                            goto Tor;
//                                                                        }
//                                                                        else
//                                                                        {
//                                                                            B6 += PlanText[q];
//                                                                            f6++;
//                                                                        }
//                                                                    }
//                                                                    goto Tor;
//                                                                }

//                                                                else
//                                                                {
//                                                                    B5 += PlanText[w];
//                                                                    f5++;
//                                                                }
//                                                            }
//                                                            goto Tor;
//                                                        }
//                                                        else
//                                                        {
//                                                            B4 += PlanText[g];
//                                                            f4++;
//                                                        }
//                                                    }
//                                                    goto Tor;
//                                                }
//                                                else
//                                                {
//                                                    B3 += PlanText[h];
//                                                    f3++;
//                                                }
//                                            }
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += PlanText[k];
//                                            f2++;
//                                        }

//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += PlanText[j];
//                                    f1++;
//                                }
//                            }
//                        Tor:
//                            if (alone1 == true)
//                                PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } });
//                            else
//                                if (alone2 == true)
//                                    PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } });
//                                else
//                                    if (alone3 == true)
//                                        PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { 0 }, { 0 }, { 0 }, { 0 } });
//                                    else
//                                        if (alone4 == true)
//                                            PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { alphabets.IndexOf(PlanText[outerh]) }, { 0 }, { 0 }, { 0 } });
//                                        else
//                                            if (alone5 == true)
//                                                PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { alphabets.IndexOf(PlanText[outerh]) }, { alphabets.IndexOf(PlanText[outerg]) }, { 0 }, { 0 } });
//                                            else
//                                                if (alone6 == true)
//                                                    PlanMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(PlanText[i]) }, { alphabets.IndexOf(PlanText[outerj]) }, { alphabets.IndexOf(PlanText[outerk]) }, { alphabets.IndexOf(PlanText[outerh]) }, { alphabets.IndexOf(PlanText[outerg]) }, { alphabets.IndexOf(PlanText[outerw]) }, { 0 } });


//                            i += f1 + f2 + f3 + f4 + f5 + f6;
//                            CipherMatrix = Matrix.Multiply(KeyMatrix, PlanMatrix);
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B1;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B2;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[2, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B3;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[3, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B4;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[4, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B5;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[5, 0]), alphabets.Length)];
//                            textBoxCipherText.Text += B6;
//                            textBoxCipherText.Text += alphabets[Mod(Convert.ToInt32(CipherMatrix[6, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxCipherText.Text += PlanText[i].ToString();
//                            i -= 6;
//                        }
//                    }
//                }
//                //******************************

//            }
//            else
//                MessageBox.Show("حقل النص الأصلي فارغ");

//        ErorrKey:
//            if (Notdogoto == false)
//                MessageBox.Show("المفتاح الذي تم إدخاله غير صالح", "مفتاح غير صالح");

//        }

//        private void buttonDecipher_Click(object sender, EventArgs e)///////////////////////////////////////////////////فك التشفير
//        {
//            if (textBoxCipherText.Text == "" || InverseKeyMatrix == null)
//                MessageBox.Show("بعض الحقول المطلوبة فارغة", "خطأ");
//            else
//            {
//                textBoxDecipherText.Clear();
//                string Ciphertext = textBoxCipherText.Text.ToUpper();

//                if (radioButton1T.Checked)
//                    for (int i = 0; i < Ciphertext.Length; i++)
//                    {
//                        if (alphabets.Contains(Ciphertext[i]))
//                        {
//                            CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) } });
//                            Matrix DecipherMatrix = Matrix.Multiply(InverseKeyMatrix, CipherMatrix);
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[0, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxDecipherText.Text += textBoxCipherText.Text[i].ToString();
//                        }
//                    }
//                if (radioButton2T.Checked)
//                {
//                    bool alone = true;

//                    for (int i = 0; i < Ciphertext.Length; i += 2)
//                    {
//                        string B1 = "";
//                        int f = 0;
//                        alone = true;
//                        if (alphabets.Contains(Ciphertext[i]))
//                        {
//                            for (int j = i + 1; j < Ciphertext.Length; j++)
//                            {
//                                if (alphabets.Contains(Ciphertext[j]))
//                                {
//                                    CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[j]) } });
//                                    alone = false;
//                                    break;
//                                }
//                                else
//                                {
//                                    B1 += Ciphertext[j];
//                                    f++;
//                                }
//                            }
//                            if (alone == true)
//                            {
//                                CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { 0 } });
//                            }
//                            i += f;
//                            DecipherMatrix = Matrix.Multiply(InverseKeyMatrix, CipherMatrix);
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B1;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[1, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxDecipherText.Text += Ciphertext[i].ToString();
//                            i--;
//                        }
//                    }
//                }

//                if (radioButton3T.Checked)
//                {

//                    for (int i = 0; i < Ciphertext.Length; i += 3)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int outerj = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        if (alphabets.Contains(Ciphertext[i]))
//                        {
//                            for (int j = i + 1; j < Ciphertext.Length; j++)
//                            {
//                                if (alphabets.Contains(Ciphertext[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < Ciphertext.Length; k++)
//                                    {
//                                        if (alphabets.Contains(Ciphertext[k]))
//                                        {
//                                            CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[j]) }, { alphabets.IndexOf(Ciphertext[k]) } });
//                                            alone2 = false;
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += Ciphertext[k];
//                                            f2++;
//                                        }
//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += Ciphertext[j];
//                                    f1++;
//                                }
//                            }
//                        Tor:
//                            if (alone1 == true)
//                            {
//                                CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { 0 }, { 0 } });
//                            }
//                            else
//                                if (alone2 == true)
//                                {
//                                    CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { 0 } });
//                                }
//                            i += f1 + f2;
//                            DecipherMatrix = Matrix.Multiply(InverseKeyMatrix, CipherMatrix);
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B1;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B2;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[2, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxDecipherText.Text += Ciphertext[i].ToString();
//                            i -= 2;
//                        }
//                    }
//                }

//                if (radioButton4T.Checked)
//                {
//                    for (int i = 0; i < Ciphertext.Length; i += 4)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        string B3 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int f3 = 0;
//                        int outerj = 0;
//                        int outerk = 0;
//                        //int outerh = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        bool alone3 = true;

//                        if (alphabets.Contains(Ciphertext[i]))
//                        {
//                            for (int j = i + 1; j < Ciphertext.Length; j++)
//                            {
//                                if (alphabets.Contains(Ciphertext[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < Ciphertext.Length; k++)
//                                    {
//                                        if (alphabets.Contains(Ciphertext[k]))
//                                        {
//                                            outerk = k;
//                                            alone2 = false;
//                                            for (int h = k + 1; h < Ciphertext.Length; h++)
//                                            {
//                                                if (alphabets.Contains(Ciphertext[h]))
//                                                {
//                                                    CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[j]) }, { alphabets.IndexOf(Ciphertext[k]) }, { alphabets.IndexOf(Ciphertext[h]) } });
//                                                    alone3 = false;
//                                                    goto Tor;
//                                                }
//                                                else
//                                                {
//                                                    B3 += Ciphertext[h];
//                                                    f3++;
//                                                }
//                                            }
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += Ciphertext[k];
//                                            f2++;
//                                        }

//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += Ciphertext[j];
//                                    f1++;
//                                }
//                            }
//                        Tor:
//                            if (alone1 == true)
//                                CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { 0 }, { 0 }, { 0 } });
//                            else
//                                if (alone2 == true)
//                                    CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { 0 }, { 0 } });
//                                else
//                                    if (alone3 == true)
//                                        CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { 0 } });

//                            i += f1 + f2 + f3;
//                            DecipherMatrix = Matrix.Multiply(InverseKeyMatrix, CipherMatrix);
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B1;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B2;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[2, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B3;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[3, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxDecipherText.Text += Ciphertext[i].ToString();
//                            i -= 3;
//                        }
//                    }
//                }

//                if (radioButton5T.Checked)
//                {
//                    for (int i = 0; i < Ciphertext.Length; i += 5)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        string B3 = "";
//                        string B4 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int f3 = 0;
//                        int f4 = 0;
//                        int outerj = 0;
//                        int outerk = 0;
//                        int outerh = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        bool alone3 = true;
//                        bool alone4 = true;

//                        if (alphabets.Contains(Ciphertext[i]))
//                        {
//                            for (int j = i + 1; j < Ciphertext.Length; j++)
//                            {
//                                if (alphabets.Contains(Ciphertext[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < Ciphertext.Length; k++)
//                                    {
//                                        if (alphabets.Contains(Ciphertext[k]))
//                                        {
//                                            outerk = k;
//                                            alone2 = false;
//                                            for (int h = k + 1; h < Ciphertext.Length; h++)
//                                            {
//                                                if (alphabets.Contains(Ciphertext[h]))
//                                                {
//                                                    outerh = h;
//                                                    alone3 = false;
//                                                    for (int g = h + 1; g < Ciphertext.Length; g++)
//                                                    {
//                                                        if (alphabets.Contains(Ciphertext[g]))
//                                                        {
//                                                            CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[j]) }, { alphabets.IndexOf(Ciphertext[k]) }, { alphabets.IndexOf(Ciphertext[h]) }, { alphabets.IndexOf(Ciphertext[g]) } });
//                                                            alone4 = false;
//                                                            goto Tor;
//                                                        }
//                                                        else
//                                                        {
//                                                            B4 += Ciphertext[g];
//                                                            f4++;
//                                                        }
//                                                    }
//                                                    goto Tor;
//                                                }
//                                                else
//                                                {
//                                                    B3 += Ciphertext[h];
//                                                    f3++;
//                                                }
//                                            }
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += Ciphertext[k];
//                                            f2++;
//                                        }

//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += Ciphertext[j];
//                                    f1++;
//                                }
//                            }
//                        Tor:
//                            if (alone1 == true)
//                            {
//                                CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { 0 }, { 0 }, { 0 }, { 0 } });
//                            }
//                            else
//                                if (alone2 == true)
//                                {
//                                    CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { 0 }, { 0 }, { 0 } });
//                                }
//                                else
//                                    if (alone3 == true)
//                                        CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { 0 }, { 0 } });
//                                    else
//                                        if (alone4 == true)
//                                            CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { alphabets.IndexOf(Ciphertext[outerh]) }, { 0 } });

//                            i += f1 + f2 + f3 + f4;
//                            DecipherMatrix = Matrix.Multiply(InverseKeyMatrix, CipherMatrix);
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B1;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B2;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[2, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B3;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[3, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B4;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[4, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxDecipherText.Text += Ciphertext[i].ToString();
//                            i -= 4;
//                        }
//                    }
//                }

//                if (radioButton6T.Checked)
//                {
//                    for (int i = 0; i < Ciphertext.Length; i += 6)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        string B3 = "";
//                        string B4 = "";
//                        string B5 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int f3 = 0;
//                        int f4 = 0;
//                        int f5 = 0;
//                        int outerj = 0;
//                        int outerk = 0;
//                        int outerh = 0;
//                        int outerg = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        bool alone3 = true;
//                        bool alone4 = true;
//                        bool alone5 = true;

//                        if (alphabets.Contains(Ciphertext[i]))
//                        {
//                            for (int j = i + 1; j < Ciphertext.Length; j++)
//                            {
//                                if (alphabets.Contains(Ciphertext[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < Ciphertext.Length; k++)
//                                    {
//                                        if (alphabets.Contains(Ciphertext[k]))
//                                        {
//                                            outerk = k;
//                                            alone2 = false;
//                                            for (int h = k + 1; h < Ciphertext.Length; h++)
//                                            {
//                                                if (alphabets.Contains(Ciphertext[h]))
//                                                {
//                                                    outerh = h;
//                                                    alone3 = false;
//                                                    for (int g = h + 1; g < Ciphertext.Length; g++)
//                                                    {
//                                                        if (alphabets.Contains(Ciphertext[g]))
//                                                        {
//                                                            outerg = g;
//                                                            alone4 = false;
//                                                            for (int w = g + 1; w < Ciphertext.Length; w++)
//                                                            {
//                                                                if (alphabets.Contains(Ciphertext[w]))
//                                                                {
//                                                                    CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[j]) }, { alphabets.IndexOf(Ciphertext[k]) }, { alphabets.IndexOf(Ciphertext[h]) }, { alphabets.IndexOf(Ciphertext[g]) }, { alphabets.IndexOf(Ciphertext[w]) } });
//                                                                    alone5 = false;
//                                                                    goto Tor;
//                                                                }
//                                                                else
//                                                                {
//                                                                    B5 += Ciphertext[w];
//                                                                    f5++;
//                                                                }
//                                                            }
//                                                            goto Tor;
//                                                        }
//                                                        else
//                                                        {
//                                                            B4 += Ciphertext[g];
//                                                            f4++;
//                                                        }
//                                                    }
//                                                    goto Tor;
//                                                }
//                                                else
//                                                {
//                                                    B3 += Ciphertext[h];
//                                                    f3++;
//                                                }
//                                            }
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += Ciphertext[k];
//                                            f2++;
//                                        }

//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += Ciphertext[j];
//                                    f1++;
//                                }

//                            }
//                        Tor:
//                            if (alone1 == true)
//                                CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } });
//                            else
//                                if (alone2 == true)
//                                    CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { 0 }, { 0 }, { 0 }, { 0 } });
//                                else
//                                    if (alone3 == true)
//                                        CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { 0 }, { 0 }, { 0 } });
//                                    else
//                                        if (alone4 == true)
//                                            CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { alphabets.IndexOf(Ciphertext[outerh]) }, { 0 }, { 0 } });
//                                        else
//                                            if (alone5 == true)
//                                                CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { alphabets.IndexOf(Ciphertext[outerh]) }, { alphabets.IndexOf(Ciphertext[outerg]) }, { 0 } });

//                            i += f1 + f2 + f3 + f4 + f5;
//                            DecipherMatrix = Matrix.Multiply(InverseKeyMatrix, CipherMatrix);
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B1;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B2;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[2, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B3;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[3, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B4;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[4, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B5;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[5, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxDecipherText.Text += Ciphertext[i].ToString();
//                            i -= 5;
//                        }
//                    }
//                }

//                if (radioButton7T.Checked)
//                {
//                    for (int i = 0; i < Ciphertext.Length; i += 7)
//                    {
//                        string B1 = "";
//                        string B2 = "";
//                        string B3 = "";
//                        string B4 = "";
//                        string B5 = "";
//                        string B6 = "";
//                        int f1 = 0;
//                        int f2 = 0;
//                        int f3 = 0;
//                        int f4 = 0;
//                        int f5 = 0;
//                        int f6 = 0;
//                        int outerj = 0;
//                        int outerk = 0;
//                        int outerh = 0;
//                        int outerg = 0;
//                        int outerw = 0;
//                        bool alone1 = true;
//                        bool alone2 = true;
//                        bool alone3 = true;
//                        bool alone4 = true;
//                        bool alone5 = true;
//                        bool alone6 = true;

//                        if (alphabets.Contains(Ciphertext[i]))
//                        {
//                            for (int j = i + 1; j < Ciphertext.Length; j++)
//                            {
//                                if (alphabets.Contains(Ciphertext[j]))
//                                {
//                                    outerj = j;
//                                    alone1 = false;
//                                    for (int k = j + 1; k < Ciphertext.Length; k++)
//                                    {
//                                        if (alphabets.Contains(Ciphertext[k]))
//                                        {
//                                            outerk = k;
//                                            alone2 = false;
//                                            for (int h = k + 1; h < Ciphertext.Length; h++)
//                                            {
//                                                if (alphabets.Contains(Ciphertext[h]))
//                                                {
//                                                    outerh = h;
//                                                    alone3 = false;
//                                                    for (int g = h + 1; g < Ciphertext.Length; g++)
//                                                    {
//                                                        if (alphabets.Contains(Ciphertext[g]))
//                                                        {
//                                                            outerg = g;
//                                                            alone4 = false;
//                                                            for (int w = g + 1; w < Ciphertext.Length; w++)
//                                                            {
//                                                                if (alphabets.Contains(Ciphertext[w]))
//                                                                {
//                                                                    outerw = w;
//                                                                    alone5 = false;
//                                                                    for (int q = w + 1; q < Ciphertext.Length; q++)
//                                                                    {
//                                                                        if (alphabets.Contains(Ciphertext[q]))
//                                                                        {
//                                                                            CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[j]) }, { alphabets.IndexOf(Ciphertext[k]) }, { alphabets.IndexOf(Ciphertext[h]) }, { alphabets.IndexOf(Ciphertext[g]) }, { alphabets.IndexOf(Ciphertext[w]) }, { alphabets.IndexOf(Ciphertext[q]) } });
//                                                                            alone6 = false;
//                                                                            goto Tor;
//                                                                        }
//                                                                        else
//                                                                        {
//                                                                            B6 += Ciphertext[q];
//                                                                            f6++;
//                                                                        }
//                                                                    }
//                                                                    goto Tor;
//                                                                }

//                                                                else
//                                                                {
//                                                                    B5 += Ciphertext[w];
//                                                                    f5++;
//                                                                }
//                                                            }
//                                                            goto Tor;
//                                                        }
//                                                        else
//                                                        {
//                                                            B4 += Ciphertext[g];
//                                                            f4++;
//                                                        }
//                                                    }
//                                                    goto Tor;
//                                                }
//                                                else
//                                                {
//                                                    B3 += Ciphertext[h];
//                                                    f3++;
//                                                }
//                                            }
//                                            goto Tor;
//                                        }
//                                        else
//                                        {
//                                            B2 += Ciphertext[k];
//                                            f2++;
//                                        }

//                                    }
//                                    goto Tor;
//                                }
//                                else
//                                {
//                                    B1 += Ciphertext[j];
//                                    f1++;
//                                }
//                            }
//                        Tor:
//                            if (alone1 == true)
//                                CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } });
//                            else
//                                if (alone2 == true)
//                                    CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } });
//                                else
//                                    if (alone3 == true)
//                                        CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { 0 }, { 0 }, { 0 }, { 0 } });
//                                    else
//                                        if (alone4 == true)
//                                            CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { alphabets.IndexOf(Ciphertext[outerh]) }, { 0 }, { 0 }, { 0 } });
//                                        else
//                                            if (alone5 == true)
//                                                CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { alphabets.IndexOf(Ciphertext[outerh]) }, { alphabets.IndexOf(Ciphertext[outerg]) }, { 0 }, { 0 } });
//                                            else
//                                                if (alone6 == true)
//                                                    CipherMatrix = new Bluebit.MatrixLibrary.Matrix(new double[,] { { alphabets.IndexOf(Ciphertext[i]) }, { alphabets.IndexOf(Ciphertext[outerj]) }, { alphabets.IndexOf(Ciphertext[outerk]) }, { alphabets.IndexOf(Ciphertext[outerh]) }, { alphabets.IndexOf(Ciphertext[outerg]) }, { alphabets.IndexOf(Ciphertext[outerw]) }, { 0 } });


//                            i += f1 + f2 + f3 + f4 + f5 + f6;
//                            DecipherMatrix = Matrix.Multiply(InverseKeyMatrix, CipherMatrix);
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[0, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B1;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[1, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B2;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[2, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B3;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[3, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B4;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[4, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B5;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[5, 0]), alphabets.Length)];
//                            textBoxDecipherText.Text += B6;
//                            textBoxDecipherText.Text += alphabets[Mod(Convert.ToInt32(DecipherMatrix[6, 0]), alphabets.Length)];
//                        }
//                        else
//                        {
//                            textBoxDecipherText.Text += Ciphertext[i].ToString();
//                            i -= 6;
//                        }
//                    }
//                }
//            }
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            button1.Enabled = true;
//            button2.Enabled = false;
//            comboBox1.Enabled = true;
//            textBoxCharToCipher.Enabled = true;
//            textBoxFirstValue.Enabled = true;
//            radioButtonCombo.Enabled = true;
//            radioButtonCustom.Enabled = true;
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            button1.Enabled = false;
//            button2.Enabled = true;
//            comboBox1.Enabled = false;
//            textBoxCharToCipher.Enabled = false;
//            textBoxFirstValue.Enabled = false;
//            radioButtonCombo.Enabled = false;
//            radioButtonCustom.Enabled = false;
//            if (radioButtonCombo.Checked == true)
//            {
//                alphabets = null;
//                alphabets = comboBox1.Text.ToUpper();
//            }
//            else
//            {
//                alphabets = null;
//                alphabets = textBoxCharToCipher.Text.ToUpper();
//            }
//        }

//        private void radioButton1T_Click(object sender, EventArgs e)
//        {
//            textBox1C.Enabled = true; textBox2C.Enabled = textBox3C.Enabled = textBox4C.Enabled = textBox5C.Enabled = textBox6C.Enabled = textBox7C.Enabled = false;
//            textBox8C.Enabled = textBox9C.Enabled = textBox10C.Enabled = textBox11C.Enabled = textBox12C.Enabled = textBox13C.Enabled = textBox14C.Enabled = false;
//            textBox15C.Enabled = textBox16C.Enabled = textBox17C.Enabled = textBox18C.Enabled = textBox19C.Enabled = textBox20C.Enabled = textBox21C.Enabled = false;
//            textBox22C.Enabled = textBox23C.Enabled = textBox24C.Enabled = textBox25C.Enabled = textBox26C.Enabled = textBox27C.Enabled = textBox28C.Enabled = false;
//            textBox29C.Enabled = textBox30C.Enabled = textBox31C.Enabled = textBox32C.Enabled = textBox33C.Enabled = textBox34C.Enabled = textBox35C.Enabled = false;
//            textBox36C.Enabled = textBox37C.Enabled = textBox38C.Enabled = textBox39C.Enabled = textBox40C.Enabled = textBox41C.Enabled = textBox42C.Enabled = false;
//            textBox43C.Enabled = textBox44C.Enabled = textBox45C.Enabled = textBox46C.Enabled = textBox47C.Enabled = textBox48C.Enabled = textBox49C.Enabled = false;
//            textBox1C.Focus();
//        }

//        private void radioButton2T_Click(object sender, EventArgs e)
//        {
//            textBox1C.Enabled = textBox2C.Enabled = true; textBox3C.Enabled = textBox4C.Enabled = textBox5C.Enabled = textBox6C.Enabled = textBox7C.Enabled = false;
//            textBox8C.Enabled = textBox9C.Enabled = true; textBox10C.Enabled = textBox11C.Enabled = textBox12C.Enabled = textBox13C.Enabled = textBox14C.Enabled = false;
//            textBox15C.Enabled = textBox16C.Enabled = textBox17C.Enabled = textBox18C.Enabled = textBox19C.Enabled = textBox20C.Enabled = textBox21C.Enabled = false;
//            textBox22C.Enabled = textBox23C.Enabled = textBox24C.Enabled = textBox25C.Enabled = textBox26C.Enabled = textBox27C.Enabled = textBox28C.Enabled = false;
//            textBox29C.Enabled = textBox30C.Enabled = textBox31C.Enabled = textBox32C.Enabled = textBox33C.Enabled = textBox34C.Enabled = textBox35C.Enabled = false;
//            textBox36C.Enabled = textBox37C.Enabled = textBox38C.Enabled = textBox39C.Enabled = textBox40C.Enabled = textBox41C.Enabled = textBox42C.Enabled = false;
//            textBox43C.Enabled = textBox44C.Enabled = textBox45C.Enabled = textBox46C.Enabled = textBox47C.Enabled = textBox48C.Enabled = textBox49C.Enabled = false;
//            textBox1C.Focus();
//        }

//        private void radioButton3T_Click(object sender, EventArgs e)
//        {
//            textBox1C.Enabled = textBox2C.Enabled = textBox3C.Enabled = true; textBox4C.Enabled = textBox5C.Enabled = textBox6C.Enabled = textBox7C.Enabled = false;
//            textBox8C.Enabled = textBox9C.Enabled = textBox10C.Enabled = true; textBox11C.Enabled = textBox12C.Enabled = textBox13C.Enabled = textBox14C.Enabled = false;
//            textBox15C.Enabled = textBox16C.Enabled = textBox17C.Enabled = true; textBox18C.Enabled = textBox19C.Enabled = textBox20C.Enabled = textBox21C.Enabled = false;
//            textBox22C.Enabled = textBox23C.Enabled = textBox24C.Enabled = textBox25C.Enabled = textBox26C.Enabled = textBox27C.Enabled = textBox28C.Enabled = false;
//            textBox29C.Enabled = textBox30C.Enabled = textBox31C.Enabled = textBox32C.Enabled = textBox33C.Enabled = textBox34C.Enabled = textBox35C.Enabled = false;
//            textBox36C.Enabled = textBox37C.Enabled = textBox38C.Enabled = textBox39C.Enabled = textBox40C.Enabled = textBox41C.Enabled = textBox42C.Enabled = false;
//            textBox43C.Enabled = textBox44C.Enabled = textBox45C.Enabled = textBox46C.Enabled = textBox47C.Enabled = textBox48C.Enabled = textBox49C.Enabled = false;
//            textBox1C.Focus();
//        }

//        private void radioButton4T_Click(object sender, EventArgs e)
//        {
//            textBox1C.Enabled = textBox2C.Enabled = textBox3C.Enabled = textBox4C.Enabled = true; textBox5C.Enabled = textBox6C.Enabled = textBox7C.Enabled = false;
//            textBox8C.Enabled = textBox9C.Enabled = textBox10C.Enabled = textBox11C.Enabled = true; textBox12C.Enabled = textBox13C.Enabled = textBox14C.Enabled = false;
//            textBox15C.Enabled = textBox16C.Enabled = textBox17C.Enabled = textBox18C.Enabled = true; textBox19C.Enabled = textBox20C.Enabled = textBox21C.Enabled = false;
//            textBox22C.Enabled = textBox23C.Enabled = textBox24C.Enabled = textBox25C.Enabled = true; textBox26C.Enabled = textBox27C.Enabled = textBox28C.Enabled = false;
//            textBox29C.Enabled = textBox30C.Enabled = textBox31C.Enabled = textBox32C.Enabled = textBox33C.Enabled = textBox34C.Enabled = textBox35C.Enabled = false;
//            textBox36C.Enabled = textBox37C.Enabled = textBox38C.Enabled = textBox39C.Enabled = textBox40C.Enabled = textBox41C.Enabled = textBox42C.Enabled = false;
//            textBox43C.Enabled = textBox44C.Enabled = textBox45C.Enabled = textBox46C.Enabled = textBox47C.Enabled = textBox48C.Enabled = textBox49C.Enabled = false;
//            textBox1C.Focus();

//        }

//        private void radioButton5T_Click(object sender, EventArgs e)
//        {
//            textBox1C.Enabled = textBox2C.Enabled = textBox3C.Enabled = textBox4C.Enabled = textBox5C.Enabled = true; textBox6C.Enabled = textBox7C.Enabled = false;
//            textBox8C.Enabled = textBox9C.Enabled = textBox10C.Enabled = textBox11C.Enabled = textBox12C.Enabled = true; textBox13C.Enabled = textBox14C.Enabled = false;
//            textBox15C.Enabled = textBox16C.Enabled = textBox17C.Enabled = textBox18C.Enabled = textBox19C.Enabled = true; textBox20C.Enabled = textBox21C.Enabled = false;
//            textBox22C.Enabled = textBox23C.Enabled = textBox24C.Enabled = textBox25C.Enabled = textBox26C.Enabled = true; textBox27C.Enabled = textBox28C.Enabled = false;
//            textBox29C.Enabled = textBox30C.Enabled = textBox31C.Enabled = textBox32C.Enabled = textBox33C.Enabled = true; textBox34C.Enabled = textBox35C.Enabled = false;
//            textBox36C.Enabled = textBox37C.Enabled = textBox38C.Enabled = textBox39C.Enabled = textBox40C.Enabled = textBox41C.Enabled = textBox42C.Enabled = false;
//            textBox43C.Enabled = textBox44C.Enabled = textBox45C.Enabled = textBox46C.Enabled = textBox47C.Enabled = textBox48C.Enabled = textBox49C.Enabled = false;
//            textBox1C.Focus();
//        }

//        private void radioButton6T_Click(object sender, EventArgs e)
//        {
//            textBox1C.Enabled = textBox2C.Enabled = textBox3C.Enabled = textBox4C.Enabled = textBox5C.Enabled = textBox6C.Enabled = true; textBox7C.Enabled = false;
//            textBox8C.Enabled = textBox9C.Enabled = textBox10C.Enabled = textBox11C.Enabled = textBox12C.Enabled = textBox13C.Enabled = true; textBox14C.Enabled = false;
//            textBox15C.Enabled = textBox16C.Enabled = textBox17C.Enabled = textBox18C.Enabled = textBox19C.Enabled = textBox20C.Enabled = true; textBox21C.Enabled = false;
//            textBox22C.Enabled = textBox23C.Enabled = textBox24C.Enabled = textBox25C.Enabled = textBox26C.Enabled = textBox27C.Enabled = true; textBox28C.Enabled = false;
//            textBox29C.Enabled = textBox30C.Enabled = textBox31C.Enabled = textBox32C.Enabled = textBox33C.Enabled = textBox34C.Enabled = true; textBox35C.Enabled = false;
//            textBox36C.Enabled = textBox37C.Enabled = textBox38C.Enabled = textBox39C.Enabled = textBox40C.Enabled = textBox41C.Enabled = true; textBox42C.Enabled = false;
//            textBox43C.Enabled = textBox44C.Enabled = textBox45C.Enabled = textBox46C.Enabled = textBox47C.Enabled = textBox48C.Enabled = textBox49C.Enabled = false;
//            textBox1C.Focus();
//        }

//        private void radioButton7T_Click(object sender, EventArgs e)
//        {
//            textBox1C.Enabled = textBox2C.Enabled = textBox3C.Enabled = textBox4C.Enabled = textBox5C.Enabled = textBox6C.Enabled = textBox7C.Enabled = true;
//            textBox8C.Enabled = textBox9C.Enabled = textBox10C.Enabled = textBox11C.Enabled = textBox12C.Enabled = textBox13C.Enabled = textBox14C.Enabled = true;
//            textBox15C.Enabled = textBox16C.Enabled = textBox17C.Enabled = textBox18C.Enabled = textBox19C.Enabled = textBox20C.Enabled = textBox21C.Enabled = true;
//            textBox22C.Enabled = textBox23C.Enabled = textBox24C.Enabled = textBox25C.Enabled = textBox26C.Enabled = textBox27C.Enabled = textBox28C.Enabled = true;
//            textBox29C.Enabled = textBox30C.Enabled = textBox31C.Enabled = textBox32C.Enabled = textBox33C.Enabled = textBox34C.Enabled = textBox35C.Enabled = true;
//            textBox36C.Enabled = textBox37C.Enabled = textBox38C.Enabled = textBox39C.Enabled = textBox40C.Enabled = textBox41C.Enabled = textBox42C.Enabled = true;
//            textBox43C.Enabled = textBox44C.Enabled = textBox45C.Enabled = textBox46C.Enabled = textBox47C.Enabled = textBox48C.Enabled = textBox49C.Enabled = true;
//            textBox1C.Focus();
//        }

//        string charValue(string Charect, string FirstValue)
//        {
//            try
//            {
//                return Convert.ToString(alphabets.IndexOf(Charect.ToUpper()) + Convert.ToInt32(FirstValue));
//            }
//            catch
//            {
//                return Convert.ToString(Convert.ToInt32(textBoxFirstValue.Text) - 1);
//            }
//        }

//        private void textBox1C_TextChanged(object sender, EventArgs e)
//        {
//            textBox2C.Focus();
//            string CV = charValue(textBox1C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox1C.Clear();
//            }
//            else
//                textBox1N.Text = CV;
//        }

//        private void textBox2C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton2T.Checked)
//                textBox3C.Focus();
//            else
//                textBox8C.Focus();

//            string CV = charValue(textBox2C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox2C.Clear();
//            }
//            else
//                textBox2N.Text = CV;
//        }

//        private void textBox3C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton3T.Checked)
//                textBox4C.Focus();
//            else
//                textBox8C.Focus();

//            string CV = charValue(textBox3C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox3C.Clear();
//            }
//            else
//                textBox3N.Text = CV;
//        }

//        private void textBox4C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton4T.Checked)
//                textBox5C.Focus();
//            else
//                textBox8C.Focus();

//            string CV = charValue(textBox4C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox4C.Clear();
//            }
//            else
//                textBox4N.Text = CV;
//        }

//        private void textBox5C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton5T.Checked)
//                textBox6C.Focus();
//            else
//                textBox8C.Focus();

//            string CV = charValue(textBox5C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox5C.Clear();
//            }
//            else
//                textBox5N.Text = CV;
//        }

//        private void textBox6C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton6T.Checked)
//                textBox7C.Focus();
//            else
//                textBox8C.Focus();

//            string CV = charValue(textBox6C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox6C.Clear();
//            }
//            else
//                textBox6N.Text = CV;
//        }

//        private void textBox7C_TextChanged(object sender, EventArgs e)
//        {
//            textBox8C.Focus();
//            string CV = charValue(textBox7C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox7C.Clear();
//            }
//            else
//                textBox7N.Text = CV;
//        }

//        private void textBox8C_TextChanged(object sender, EventArgs e)
//        {
//            textBox9C.Focus();
//            string CV = charValue(textBox8C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox8C.Clear();
//            }
//            else
//                textBox8N.Text = CV;
//        }

//        private void textBox9C_TextChanged(object sender, EventArgs e)
//        {
//            textBox10C.Focus();
//            string CV = charValue(textBox9C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox9C.Clear();
//            }
//            else
//                textBox9N.Text = CV;
//        }

//        private void textBox10C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton3T.Checked)
//                textBox11C.Focus();
//            else
//                textBox15C.Focus();

//            string CV = charValue(textBox10C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox10C.Clear();
//            }
//            else
//                textBox10N.Text = CV;
//        }

//        private void textBox11C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton4T.Checked)
//                textBox12C.Focus();
//            else
//                textBox15C.Focus();

//            string CV = charValue(textBox11C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox11C.Clear();
//            }
//            else
//                textBox11N.Text = CV;
//        }

//        private void textBox12C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton5T.Checked)
//                textBox13C.Focus();
//            else
//                textBox15C.Focus();

//            string CV = charValue(textBox12C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox12C.Clear();
//            }
//            else
//                textBox12N.Text = CV;
//        }

//        private void textBox13C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton6T.Checked)
//                textBox14C.Focus();
//            else
//                textBox15C.Focus();

//            string CV = charValue(textBox13C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox13C.Clear();
//            }
//            else
//                textBox13N.Text = CV;
//        }

//        private void textBox14C_TextChanged(object sender, EventArgs e)
//        {
//            textBox15C.Focus();
//            string CV = charValue(textBox14C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox14C.Clear();
//            }
//            else
//                textBox14N.Text = CV;
//        }

//        private void textBox15C_TextChanged(object sender, EventArgs e)
//        {
//            string CV = charValue(textBox15C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox15C.Clear();
//            }
//            else
//            {
//                textBox15N.Text = CV;
//                textBox16C.Focus();
//            }
//        }

//        private void textBox16C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton2T.Checked)
//                textBox17C.Focus();
//            else
//                textBox22C.Focus();

//            string CV = charValue(textBox16C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox16C.Clear();
//            }
//            else
//                textBox16N.Text = CV;
//        }

//        private void textBox17C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton3T.Checked)
//                textBox18C.Focus();
//            else
//                textBox22C.Focus();

//            string CV = charValue(textBox17C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox17C.Clear();
//            }
//            else
//                textBox17N.Text = CV;
//        }

//        private void textBox18C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton4T.Checked)
//                textBox19C.Focus();
//            else
//                textBox22C.Focus();

//            string CV = charValue(textBox18C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox18C.Clear();
//            }
//            else
//                textBox18N.Text = CV;
//        }

//        private void textBox19C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton5T.Checked)
//                textBox20C.Focus();
//            else
//                textBox22C.Focus();

//            string CV = charValue(textBox19C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox19C.Clear();
//            }
//            else
//                textBox19N.Text = CV;
//        }

//        private void textBox20C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton6T.Checked)
//                textBox21C.Focus();
//            else
//                textBox22C.Focus();

//            string CV = charValue(textBox20C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox20C.Clear();
//            }
//            else
//                textBox20N.Text = CV;
//        }

//        private void textBox21C_TextChanged(object sender, EventArgs e)
//        {
//            textBox22C.Focus();
//            string CV = charValue(textBox21C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox21C.Clear();
//            }
//            else
//                textBox21N.Text = CV;
//        }

//        private void textBox22C_TextChanged(object sender, EventArgs e)
//        {
//            textBox23C.Focus();
//            string CV = charValue(textBox22C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox22C.Clear();
//            }
//            else
//                textBox22N.Text = CV;
//        }

//        private void textBox23C_TextChanged(object sender, EventArgs e)
//        {
//            textBox24C.Focus();
//            string CV = charValue(textBox23C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox23C.Clear();
//            }
//            else
//                textBox23N.Text = CV;
//        }

//        private void textBox24C_TextChanged(object sender, EventArgs e)
//        {
//            textBox25C.Focus();
//            string CV = charValue(textBox24C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox24C.Clear();
//            }
//            else
//                textBox24N.Text = CV;
//        }

//        private void textBox25C_TextChanged(object sender, EventArgs e)
//        {
//            textBox26C.Focus();
//            string CV = charValue(textBox25C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox25C.Clear();
//            }
//            else
//                textBox25N.Text = CV;
//        }

//        private void textBox26C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton5T.Checked)
//                textBox27C.Focus();
//            else
//                textBox29C.Focus();
//            string CV = charValue(textBox26C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox26C.Clear();
//            }
//            else
//                textBox26N.Text = CV;
//        }

//        private void textBox27C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton6T.Checked)
//                textBox28C.Focus();
//            else
//                textBox29C.Focus();
//            string CV = charValue(textBox27C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox27C.Clear();
//            }
//            else
//                textBox27N.Text = CV;
//        }

//        private void textBox28C_TextChanged(object sender, EventArgs e)
//        {
//            textBox29C.Focus();
//            string CV = charValue(textBox28C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox28C.Clear();
//            }
//            else
//                textBox28N.Text = CV;
//        }

//        private void textBox29C_TextChanged(object sender, EventArgs e)
//        {
//            textBox30C.Focus();
//            string CV = charValue(textBox29C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox29C.Clear();
//            }
//            else
//                textBox29N.Text = CV;

//        }

//        private void textBox30C_TextChanged(object sender, EventArgs e)
//        {
//            textBox31C.Focus();
//            string CV = charValue(textBox30C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox30C.Clear();
//            }
//            else
//                textBox30N.Text = CV;

//        }

//        private void textBox31C_TextChanged(object sender, EventArgs e)
//        {
//            textBox32C.Focus();
//            string CV = charValue(textBox31C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox31C.Clear();
//            }
//            else
//                textBox31N.Text = CV;

//        }

//        private void textBox32C_TextChanged(object sender, EventArgs e)
//        {
//            textBox33C.Focus();
//            string CV = charValue(textBox32C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox32C.Clear();
//            }
//            else
//                textBox32N.Text = CV;

//        }

//        private void textBox33C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton5T.Checked)
//                textBox34C.Focus();
//            string CV = charValue(textBox33C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox33C.Clear();
//            }
//            else
//                textBox33N.Text = CV;

//        }

//        private void textBox34C_TextChanged(object sender, EventArgs e)
//        {
//            if (!radioButton6T.Checked)
//                textBox35C.Focus();
//            else
//                textBox36C.Focus();
//            string CV = charValue(textBox34C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox34C.Clear();
//            }
//            else
//                textBox34N.Text = CV;
//        }

//        private void textBox35C_TextChanged(object sender, EventArgs e)
//        {
//            textBox36C.Focus();
//            string CV = charValue(textBox35C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox35C.Clear();
//            }
//            else
//                textBox35N.Text = CV;
//        }

//        private void textBox36C_TextChanged(object sender, EventArgs e)
//        {
//            textBox37C.Focus();
//            string CV = charValue(textBox36C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox36C.Clear();
//            }
//            else
//                textBox36N.Text = CV;
//        }

//        private void textBox37C_TextChanged(object sender, EventArgs e)
//        {
//            textBox38C.Focus();
//            string CV = charValue(textBox37C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox37C.Clear();
//            }
//            else
//                textBox37N.Text = CV;
//        }

//        private void textBox38C_TextChanged(object sender, EventArgs e)
//        {
//            textBox39C.Focus();
//            string CV = charValue(textBox38C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox38C.Clear();
//            }
//            else
//                textBox38N.Text = CV;
//        }

//        private void textBox39C_TextChanged(object sender, EventArgs e)
//        {
//            textBox40C.Focus();
//            string CV = charValue(textBox39C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox39C.Clear();
//            }
//            else
//                textBox39N.Text = CV;
//        }

//        private void textBox40C_TextChanged(object sender, EventArgs e)
//        {
//            textBox41C.Focus();
//            string CV = charValue(textBox40C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox40C.Clear();
//            }
//            else
//                textBox40N.Text = CV;
//        }

//        private void textBox41C_TextChanged(object sender, EventArgs e)
//        {
//            textBox42C.Focus();
//            string CV = charValue(textBox41C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox41C.Clear();
//            }
//            else
//                textBox41N.Text = CV;
//        }

//        private void textBox42C_TextChanged(object sender, EventArgs e)
//        {
//            textBox43C.Focus();
//            string CV = charValue(textBox42C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox42C.Clear();
//            }
//            else
//                textBox42N.Text = CV;
//        }

//        private void textBox43C_TextChanged(object sender, EventArgs e)
//        {
//            textBox44C.Focus();
//            string CV = charValue(textBox43C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox43C.Clear();
//            }
//            else
//                textBox43N.Text = CV;
//        }

//        private void textBox44C_TextChanged(object sender, EventArgs e)
//        {
//            textBox45C.Focus();
//            string CV = charValue(textBox44C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox44C.Clear();
//            }
//            else
//                textBox44N.Text = CV;
//        }

//        private void textBox45C_TextChanged(object sender, EventArgs e)
//        {
//            textBox46C.Focus();
//            string CV = charValue(textBox45C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox45C.Clear();
//            }
//            else
//                textBox45N.Text = CV;
//        }

//        private void textBox46C_TextChanged(object sender, EventArgs e)
//        {
//            textBox47C.Focus();
//            string CV = charValue(textBox46C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox46C.Clear();
//            }
//            else
//                textBox46N.Text = CV;
//        }

//        private void textBox47C_TextChanged(object sender, EventArgs e)
//        {
//            textBox48C.Focus();
//            string CV = charValue(textBox47C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox47C.Clear();
//            }
//            else
//                textBox47N.Text = CV;
//        }

//        private void textBox48C_TextChanged(object sender, EventArgs e)
//        {
//            textBox49C.Focus();
//            string CV = charValue(textBox48C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox48C.Clear();
//            }
//            else
//                textBox48N.Text = CV;
//        }

//        private void textBox49C_TextChanged(object sender, EventArgs e)
//        {
//            textBox1C.Focus();
//            string CV = charValue(textBox49C.Text, textBoxFirstValue.Text);
//            if (Convert.ToInt32(CV) == Convert.ToInt32(textBoxFirstValue.Text) - 1)
//            {
//                MessageBox.Show("الرمز المدخل غير معرف", "خطأ في الإدخال");
//                textBox49C.Clear();
//            }
//            else
//                textBox49N.Text = CV;
//        }

//        private void button3ClearKey_Click(object sender, EventArgs e)
//        {
//            textBox1N.Clear(); textBox8N.Clear(); textBox15N.Clear(); textBox22N.Clear(); textBox29N.Clear(); textBox36N.Clear(); textBox43N.Clear();
//            textBox2N.Clear(); textBox9N.Clear(); textBox16N.Clear(); textBox23N.Clear(); textBox30N.Clear(); textBox37N.Clear(); textBox44N.Clear();
//            textBox3N.Clear(); textBox10N.Clear(); textBox17N.Clear(); textBox24N.Clear(); textBox31N.Clear(); textBox38N.Clear(); textBox45N.Clear();
//            textBox4N.Clear(); textBox11N.Clear(); textBox18N.Clear(); textBox25N.Clear(); textBox32N.Clear(); textBox39N.Clear(); textBox46N.Clear();
//            textBox5N.Clear(); textBox12N.Clear(); textBox19N.Clear(); textBox26N.Clear(); textBox33N.Clear(); textBox40N.Clear(); textBox47N.Clear();
//            textBox6N.Clear(); textBox13N.Clear(); textBox20N.Clear(); textBox27N.Clear(); textBox34N.Clear(); textBox41N.Clear(); textBox48N.Clear();
//            textBox7N.Clear(); textBox14N.Clear(); textBox21N.Clear(); textBox28N.Clear(); textBox35N.Clear(); textBox42N.Clear(); textBox49N.Clear();

//            textBox1C.Clear(); textBox8C.Clear(); textBox15C.Clear(); textBox22C.Clear(); textBox29C.Clear(); textBox36C.Clear(); textBox43C.Clear();
//            textBox2C.Clear(); textBox9C.Clear(); textBox16C.Clear(); textBox23C.Clear(); textBox30C.Clear(); textBox37C.Clear(); textBox44C.Clear();
//            textBox3C.Clear(); textBox10C.Clear(); textBox17C.Clear(); textBox24C.Clear(); textBox31C.Clear(); textBox38C.Clear(); textBox45C.Clear();
//            textBox4C.Clear(); textBox11C.Clear(); textBox18C.Clear(); textBox25C.Clear(); textBox32C.Clear(); textBox39C.Clear(); textBox46C.Clear();
//            textBox5C.Clear(); textBox12C.Clear(); textBox19C.Clear(); textBox26C.Clear(); textBox33C.Clear(); textBox40C.Clear(); textBox47C.Clear();
//            textBox6C.Clear(); textBox13C.Clear(); textBox20C.Clear(); textBox27C.Clear(); textBox34C.Clear(); textBox41C.Clear(); textBox48C.Clear();
//            textBox7C.Clear(); textBox14C.Clear(); textBox21C.Clear(); textBox28C.Clear(); textBox35C.Clear(); textBox42C.Clear(); textBox49C.Clear();

//            textBox1C.Focus();


//        }

//        private void buttonRightToLeft_Click(object sender, EventArgs e)
//        {
//            textBoxPlanText.RightToLeft = RightToLeft.Yes;
//            textBoxCipherText.RightToLeft = RightToLeft.Yes;
//            textBoxDecipherText.RightToLeft = RightToLeft.Yes;
//            textBoxPlanText.Focus();
//        }

//        private void buttonNotRightToLeft_Click(object sender, EventArgs e)
//        {
//            textBoxPlanText.RightToLeft = RightToLeft.No;
//            textBoxCipherText.RightToLeft = RightToLeft.No;
//            textBoxDecipherText.RightToLeft = RightToLeft.No;
//            textBoxPlanText.Focus();
//        }


//    }
//}
