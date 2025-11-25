using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        int N = 1; 
        int i = 0;
        int j = 0;
        int Change;
        double[,] A = new double[6, 6]; // матриця А
        double[,] A_copy = new double[6, 6]; // копія матриці А для методу Гауса
        double[] B = new double[6]; // вектор правої частини СЛАР
        double[] B_copy = new double[6]; // копія вектора B для методу Гауса
        double[] X = new double[6]; // вектор розв'язку СЛАР

        public Form1()
        {
            InitializeComponent();
        }

        private bool Decomp(int N, ref int Change)
        {
            int i, j, k;
            double R;
            Change = 1;

            // Перевірка на нульову матрицю
            bool allZero = true;
            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    if (Math.Abs(A[i, j]) > 1e-15)
                    {
                        allZero = false;
                        break;
                    }
                }
                if (!allZero) break;
            }
            if (allZero)
            {
                MessageBox.Show("Матриця A є нульовою!", "Помилка");
                return false;
            }

            double max = Math.Abs(A[1, 1]);
            int maxRow = 1;

            for (i = 2; i <= N; i++)
            {
                if (Math.Abs(A[i, 1]) > max)
                {
                    max = Math.Abs(A[i, 1]);
                    maxRow = i;
                }
            }

            // Перевірка на виродженість після вибору головного елемента
            if (max < 1e-15)
            {
                MessageBox.Show("Матриця вироджена! Не можливо вибрати головний елемент.", "Помилка");
                return false;
            }

            if (maxRow != 1)
            {
                Change = maxRow;
                for (j = 1; j <= N; j++)
                {
                    double temp = A[1, j];
                    A[1, j] = A[maxRow, j];
                    A[maxRow, j] = temp;
                }
            }

            // Перевірка ділення на нуль
            if (Math.Abs(A[1, 1]) < 1e-15)
            {
                MessageBox.Show("Ділення на нуль при LU-розкладі!", "Помилка");
                return false;
            }

            for (i = 2; i <= N; i++)
            {
                A[1, i] = A[1, i] / A[1, 1];
            }

            for (i = 2; i <= N; i++)
            {
                for (k = i; k <= N; k++)
                {
                    R = 0;
                    for (j = 1; j < i; j++)
                    {
                        R += A[k, j] * A[j, i];
                    }
                    A[k, i] = A[k, i] - R;
                }

                // Перевірка діагонального елемента
                if (Math.Abs(A[i, i]) < 1e-15)
                {
                    MessageBox.Show($"Матриця вироджена на кроці {i} LU-розкладу!", "Помилка");
                    return false;
                }

                for (k = i + 1; k <= N; k++)
                {
                    R = 0;
                    for (j = 1; j < i; j++)
                    {
                        R += A[i, j] * A[j, k];
                    }
                    A[i, k] = (A[i, k] - R) / A[i, i];
                }
            }

            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                {
                    C_matrix_dgv.Rows[i].Cells[j].Value = A[i + 1, j + 1].ToString("F4");
                }

            return true;
        }

        private bool Solve(int Change, int N)
        {
            int i, j;
            double R;

            if (Change != 1)
            {
                double temp = B[1];
                B[1] = B[Change];
                B[Change] = temp;
            }

            // Перевірка ділення на нуль
            if (Math.Abs(A[1, 1]) < 1e-15)
            {
                MessageBox.Show("Ділення на нуль при розв'язанні системи!", "Помилка");
                return false;
            }

            B[1] = B[1] / A[1, 1];

            for (i = 2; i <= N; i++)
            {
                R = 0;
                for (j = 1; j < i; j++)
                {
                    R += A[i, j] * B[j];
                }
                B[i] = (B[i] - R) / A[i, i];
            }

            X[N] = B[N];

            for (i = N - 1; i >= 1; i--)
            {
                R = 0;
                for (j = i + 1; j <= N; j++)
                {
                    R += A[i, j] * X[j];
                }
                X[i] = B[i] - R;
            }

            return true;
        }

        private bool GaussMethod(int N)
        {
            int i, j, k;
            double max, temp;
            int maxRow;

            // Перевірка на нульову матрицю
            bool allZero = true;
            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    if (Math.Abs(A[i, j]) > 1e-15)
                    {
                        allZero = false;
                        break;
                    }
                }
                if (!allZero) break;
            }
            if (allZero)
            {
                MessageBox.Show("Матриця A є нульовою!", "Помилка");
                return false;
            }

            for (i = 1; i <= N; i++)
            {
                B_copy[i] = B[i];
                for (j = 1; j <= N; j++)
                {
                    A_copy[i, j] = A[i, j];
                }
            }

            for (k = 1; k <= N - 1; k++)
            {
                max = Math.Abs(A_copy[k, k]);
                maxRow = k;

                for (i = k + 1; i <= N; i++)
                {
                    if (Math.Abs(A_copy[i, k]) > max)
                    {
                        max = Math.Abs(A_copy[i, k]);
                        maxRow = i;
                    }
                }

                // Перевірка на виродженість
                if (max < 1e-15)
                {
                    MessageBox.Show($"Матриця вироджена на кроці {k} методу Гауса!", "Помилка");
                    return false;
                }

                if (maxRow != k)
                {
                    for (j = k; j <= N; j++)
                    {
                        temp = A_copy[k, j];
                        A_copy[k, j] = A_copy[maxRow, j];
                        A_copy[maxRow, j] = temp;
                    }
                    temp = B_copy[k];
                    B_copy[k] = B_copy[maxRow];
                    B_copy[maxRow] = temp;
                }

                for (i = k + 1; i <= N; i++)
                {
                    double factor = A_copy[i, k] / A_copy[k, k];

                    // Перевірка на некоректний множник
                    if (double.IsInfinity(factor) || double.IsNaN(factor))
                    {
                        MessageBox.Show("Некоректні обчислення в методі Гауса!", "Помилка");
                        return false;
                    }

                    for (j = k; j <= N; j++)
                    {
                        A_copy[i, j] = A_copy[i, j] - factor * A_copy[k, j];
                    }
                    B_copy[i] = B_copy[i] - factor * B_copy[k];
                }
            }

            // Перевірка останнього діагонального елемента
            if (Math.Abs(A_copy[N, N]) < 1e-15)
            {
                MessageBox.Show("Матриця вироджена!", "Помилка");
                return false;
            }

            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                {
                    C_matrix_dgv.Rows[i].Cells[j].Value = A_copy[i + 1, j + 1].ToString("F4");
                }

            X[N] = B_copy[N] / A_copy[N, N];

            // Перевірка на коректність розв'язку
            if (double.IsInfinity(X[N]) || double.IsNaN(X[N]))
            {
                MessageBox.Show("Некоректний розв'язок системи!", "Помилка");
                return false;
            }

            for (i = N - 1; i >= 1; i--)
            {
                double sum = 0;
                for (j = i + 1; j <= N; j++)
                {
                    sum += A_copy[i, j] * X[j];
                }
                X[i] = (B_copy[i] - sum) / A_copy[i, i];

                // Перевірка на коректність проміжних розв'язків
                if (double.IsInfinity(X[i]) || double.IsNaN(X[i]))
                {
                    MessageBox.Show("Некоректний проміжний розв'язок системи!", "Помилка");
                    return false;
                }
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X_vector_dgv.ReadOnly = true; // заборона введення даних у стовпець розв'язків
            C_matrix_dgv.ReadOnly = true; // заборона введення даних у матрицю C

            // Заборона додавати рядки у гріди матриці А та векторів В та Х.
            A_matrix_dgv.AllowUserToAddRows = false;
            B_vector_dgv.AllowUserToAddRows = false;
            X_vector_dgv.AllowUserToAddRows = false;
            C_matrix_dgv.AllowUserToAddRows = false;

            A_matrix_dgv.ColumnCount = 1;
            A_matrix_dgv.RowCount = 1;
            X_vector_dgv.ColumnCount = 1;
            X_vector_dgv.RowCount = 1;
            B_vector_dgv.ColumnCount = 1;
            B_vector_dgv.RowCount = 1;
            C_matrix_dgv.ColumnCount = 1;
            C_matrix_dgv.RowCount = 1;

            comboBox1.Items.Add("Метод LU-перетворення");
            comboBox1.Items.Add("Метод Гауса");
            comboBox1.SelectedIndex = 0;
        }

        private void NUD_rozmir_ValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt16(NUD_rozmir.Value);

            // Перевірка максимального розміру
            if (N > 5)
            {
                MessageBox.Show("Максимальний розмір системи - 5!", "Попередження");
                NUD_rozmir.Value = 5;
                N = 5;
            }

            A_matrix_dgv.RowCount = N;
            A_matrix_dgv.ColumnCount = N;
            X_vector_dgv.RowCount = N;
            B_vector_dgv.RowCount = N;
            C_matrix_dgv.RowCount = N;
            C_matrix_dgv.ColumnCount = N;

            A_matrix_dgv.AllowUserToAddRows = false;
            B_vector_dgv.AllowUserToAddRows = false;
            X_vector_dgv.AllowUserToAddRows = false;
            C_matrix_dgv.AllowUserToAddRows = false;
        }

        private void BСreateGrid_Click(object sender, EventArgs e)
        {
            bool exc_A = false;
            bool exc_B = false;

            // Перевірка чи вибрано метод
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть метод розв'язання!", "Помилка");
                return;
            }

            // Перевірка розмірності
            if (N < 1)
            {
                MessageBox.Show("Розмірність системи повинна бути більше 0!", "Помилка");
                return;
            }

            // Зчитування матриці A
            for (i = 1; i <= N; i++)
                for (j = 1; j <= N; j++)
                {
                    try
                    {
                        if (A_matrix_dgv[j - 1, i - 1].Value == null ||
                            string.IsNullOrWhiteSpace(A_matrix_dgv[j - 1, i - 1].Value.ToString()))
                        {
                            A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Red;
                            exc_A = true;
                        }
                        else
                        {
                            A[i, j] = Convert.ToDouble(A_matrix_dgv[j - 1, i - 1].Value);

                            // Перевірка на NaN або Infinity
                            if (double.IsNaN(A[i, j]) || double.IsInfinity(A[i, j]))
                            {
                                MessageBox.Show($"Некоректне значення в матриці A[{i},{j}]!", "Помилка");
                                return;
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Red;
                        exc_A = true;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show($"Занадто велике значення в матриці A[{i},{j}]!", "Помилка");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при зчитуванні матриці A: {ex.Message}", "Помилка");
                        return;
                    }
                }

            // Зчитування вектора B
            for (j = 0; j < N; j++)
            {
                try
                {
                    if (B_vector_dgv[0, j].Value == null ||
                        string.IsNullOrWhiteSpace(B_vector_dgv[0, j].Value.ToString()))
                    {
                        B_vector_dgv[0, j].Style.ForeColor = Color.Red;
                        exc_B = true;
                    }
                    else
                    {
                        B[j + 1] = Convert.ToDouble(B_vector_dgv[0, j].Value);

                        // Перевірка на NaN або Infinity
                        if (double.IsNaN(B[j + 1]) || double.IsInfinity(B[j + 1]))
                        {
                            MessageBox.Show($"Некоректне значення у векторі B[{j + 1}]!", "Помилка");
                            return;
                        }
                    }
                }
                catch (FormatException)
                {
                    B_vector_dgv[0, j].Style.ForeColor = Color.Red;
                    exc_B = true;
                }
                catch (OverflowException)
                {
                    MessageBox.Show($"Занадто велике значення у векторі B[{j + 1}]!", "Помилка");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при зчитуванні вектора B: {ex.Message}", "Помилка");
                    return;
                }
            }

            if (exc_A || exc_B)
            {
                MessageBox.Show("Помилка введення! Перевірте клітинки.", "Помилка");
                return;
            }

            bool success = false;

            if (comboBox1.SelectedIndex == 0)
            {
                if (Decomp(N, ref Change) && Solve(Change, N))
                {
                    success = true;
                    MessageBox.Show("Розв'язок знайдено методом LU-перетворення");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (GaussMethod(N))
                {
                    success = true;
                    MessageBox.Show("Розв'язок знайдено методом Гауса");
                }
            }

            if (success)
            {
                for (i = 0; i < N; i++)
                {
                    // Перевірка коректності розв'язку перед виведенням
                    if (double.IsNaN(X[i + 1]) || double.IsInfinity(X[i + 1]))
                    {
                        MessageBox.Show("Отримано некоректний розв'язок!", "Помилка");
                        X_vector_dgv[0, i].Value = "Помилка";
                    }
                    else
                    {
                        X_vector_dgv[0, i].Value = X[i + 1].ToString("F4");
                    }
                }
            }
            else
            {
                // Очищення результату при неуспішному розв'язанні
                for (i = 0; i < N; i++)
                {
                    X_vector_dgv[0, i].Value = "";
                }
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                {
                    A_matrix_dgv[j, i].Value = "";
                    A_matrix_dgv[j, i].Style.ForeColor = Color.Black;
                    C_matrix_dgv[j, i].Value = "";
                }
            for (j = 0; j < N; j++)
            {
                B_vector_dgv[0, j].Value = "";
                B_vector_dgv[0, j].Style.ForeColor = Color.Black;
                X_vector_dgv[0, j].Value = "";
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void A_matrix_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                A_matrix_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
        }

        private void B_vector_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                B_vector_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
        }

        private void A_matrix_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}