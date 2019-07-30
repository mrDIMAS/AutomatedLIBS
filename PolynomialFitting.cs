using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedLIBS {
    /// <summary>
    /// Class implementing LU decomposition
    /// </summary>
    public class LUDecomposition {
        public double[,] L { private set; get; }
        public double[,] U { private set; get; }

        private int[] permutation;
        private double[] rowBuffer;

        /// <summary>
        /// An implementation of LU decomposition.
        /// </summary>
        /// <param name="matrix">A square decomposable matrix</param>
        public LUDecomposition(double[,] matrix) {
            int rows = matrix.Rows();
            int cols = matrix.Cols();

            if (rows != cols) {
                throw new ArgumentException("Matrix is not square");
            }

            // generate LU matrices
            L = Matrix.Identity(cols);
            U = (double[,])matrix.Clone();

            // used for quick swapping rows
            rowBuffer = new double[cols];

            permutation = Enumerable.Range(0, rows).ToArray();

            double singular = 0;
            int pivotRow = 0;

            for (int k = 0; k < cols - 1; k++) {
                singular = 0;
                // find the pivot row
                for (int i = k; i < rows; i++) {
                    if (Math.Abs(U[i, k]) > singular) {
                        singular = Math.Abs(U[i, k]);
                        pivotRow = i;
                    }
                }

                if (singular == 0) {
                    new ArgumentException("Matrix is singlar");
                }

                Swap(ref permutation[k], ref permutation[pivotRow]);

                for (int i = 0; i < k; i++) {
                    Swap(ref L[k, i], ref L[pivotRow, i]);
                }

                SwapRows(U, k, pivotRow);

                for (int i = k + 1; i < rows; i++) {
                    L[i, k] = U[i, k] / U[k, k];
                    for (int j = k; j < cols; j++) {
                        U[i, j] = U[i, j] - L[i, k] * U[k, j];
                    }
                }
            }
        }

        public double[,] Solve(double[,] matrix) {
            if (matrix.Rows() != L.Rows()) {
                throw new ArgumentException("Invalid matrix size");
            }

            double[,] ret = new double[matrix.Rows(), matrix.Cols()];
            double[] vec = new double[matrix.Rows()];

            // solve each column
            for (int col = 0; col < matrix.Cols(); col++) {
                for (int j = 0; j < matrix.Rows(); j++) {
                    vec[j] = matrix[permutation[j], col];
                }
                var forwardSub = ForwardSub(L, vec);
                var backSub = BackSub(U, forwardSub);

                // copy the backward subsituted values to the result column
                for (int k = 0; k < backSub.Length; k++) {
                    ret[k, col] = backSub[k];
                }
            }
            return ret;
        }

        public double[] Solve(double[] vector) {
            if (U.Rows() != vector.Length) {
                throw new ArgumentException("Argument matrix has wrong number of rows");
            }

            double[] vec = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++) {
                vec[i] = vector[permutation[i]];
            }

            double[] z = ForwardSub(L, vec);
            double[] x = BackSub(U, z);

            return x;
        }

        private double[] ForwardSub(double[,] matrix, double[] b) {
            int rows = L.Rows();
            double[] ret = new double[rows];

            for (int i = 0; i < rows; i++) {
                ret[i] = b[i];
                for (int j = 0; j < i; j++) {
                    ret[i] -= matrix[i, j] * ret[j];
                }
                ret[i] = ret[i] / matrix[i, i];
            }
            return ret;
        }

        private double[] BackSub(double[,] matrix, double[] b) {
            int rows = L.Rows();
            double[] ret = new double[rows];

            for (int i = rows - 1; i > -1; i--) {
                ret[i] = b[i];
                for (int j = rows - 1; j > i; j--) {
                    ret[i] -= matrix[i, j] * ret[j];
                }
                ret[i] = ret[i] / matrix[i, i];
            }
            return ret;
        }

        private void SwapRows(double[,] matrix, int rowA, int rowB) {
            int rowSize = 8 * matrix.Cols();
            Buffer.BlockCopy(matrix, rowB * rowSize, rowBuffer, 0, rowSize);
            Buffer.BlockCopy(matrix, rowA * rowSize, matrix, rowB * rowSize, rowSize);
            Buffer.BlockCopy(rowBuffer, 0, matrix, rowA * rowSize, rowSize);
        }

        private void Swap<T>(ref T a, ref T b) {
            T c = a;
            a = b;
            b = c;
        }
    }

    /// <summary>
    /// Implements simple Matrix functions needed for polynomial fitting
    /// </summary>
    public static class Matrix {
        /// <summary>
        /// Get the number of rows in a matrix
        /// </summary>
        /// <param name="self">2d double array representing a matrix</param>
        /// <returns>Number of rows in a matrix</returns>
        public static int Rows(this double[,] self) {
            return self.GetLength(0);
        }

        /// <summary>
        /// Get the number of columns in a matrix
        /// </summary>
        /// <param name="self">2d double array representing a matrix</param>
        /// <returns>Number of columns in a matrix</returns>
        public static int Cols(this double[,] self) {
            return self.GetLength(1);
        }

        /// <summary>
        /// Transpose a matrix.
        /// </summary>
        /// <param name="self">Matrix to be transposed</param>
        /// <returns>Transposed matrix</returns>
        public static double[,] Transpose(this double[,] self) {
            double[,] trans = new double[self.Cols(), self.Rows()];

            for (int row = 0; row < self.Rows(); row++) {
                for (int col = 0; col < self.Cols(); col++) {
                    trans[col, row] = self[row, col];
                }
            }

            return trans;
        }

        /// <summary>
        /// Calculate a dot product between two matrices.
        /// </summary>
        /// <param name="self">Matrix A</param>
        /// <param name="other">Matrix B</param>
        /// <returns>Dot product of A*B</returns>
        public static double[,] Product(this double[,] self, double[,] other) {
            if (self.Cols() != other.Rows()) {
                throw new ArgumentException("Invalid matrix size");
            }

            double[,] prod = new double[self.Rows(), other.Cols()];

            for (int i = 0; i < self.Rows(); i++)
                for (int j = 0; j < other.Cols(); j++)
                    for (int k = 0; k < self.Cols(); k++)
                        prod[i, j] += self[i, k] * other[k, j];

            return prod;
        }

        /// <summary>
        /// Set the matrix so that it is an identity matrix.
        /// </summary>
        /// <param name="self">Matrix to be set to identity.</param>
        public static void Identity(this double[,] self) {
            if (self.Cols() != self.Rows()) {
                throw new ArgumentException("Argument matrix is not square!");
            }
            Array.Clear(self, 0, self.Length);
            for (int i = 0; i < self.Rows(); i++) {
                self[i, i] = 1;
            }
        }

        /// <summary>
        /// Get the matrix column as IEnumerable.
        /// </summary>
        /// <param name="self">Matrix</param>
        /// <param name="col">Column to enumerate</param>
        /// <returns>Enumerated column from a given matrix.</returns>
        public static IEnumerable<double> GetColumn(this double[,] self, int col) {
            if (col < 0 || col >= self.Cols()) {
                throw new ArgumentException("Specified column is out of range");
            }

            for (int row = 0; row < self.Rows(); row++) {
                yield return self[row, col];
            }
        }

        /// <summary>
        /// Get the matrix row as IEnumerable.
        /// </summary>
        /// <param name="self">Matrix</param>
        /// <param name="col">Row to enumerate</param>
        /// <returns>Enumerated row from a given matrix.</returns>
        public static IEnumerable<double> GetRow(this double[,] self, int row) {
            if (row < 0 || row >= self.Rows()) {
                throw new ArgumentException("Specified row is out of range");
            }

            for (int col = 0; col < self.Cols(); col++) {
                yield return self[row, col];
            }
        }

        /// <param name="size">Number of rows/cols in a matrix</param>
        /// <returns>Identity matrix</returns>
        public static double[,] Identity(int size) {
            double[,] matrix = new double[size, size];
            for (int i = 0; i < size; i++) {
                matrix[i, i] = 1;
            }
            return matrix;
        }
    }

    public class PolyFit {
        /// <summary>
        /// Coefficients of a polynomial starting at the constant coefficient 
        /// and ending with the coefficient of power to the chosen order.
        /// </summary>
        public double[] Coeff { get; private set; }

        /// <summary>
        /// Finds the coefficients of a polynomial p(x) of degree n that fits the data, 
        /// p(x(i)) to y(i), in a least squares sense. The result p is a row vector of 
        /// length n+1 containing the polynomial coefficients in incremental powers.
        /// </summary>
        /// <param name="x">x axis values</param>
        /// <param name="y">y axis values</param>
        /// <param name="order">polynomial order including the constant</param>
        public PolyFit(double[] x, double[] y, int order) {
            // incrememnt the order to match matlab way
            double[,] matrixX = new double[x.Count(), ++order];
            double[,] matrixY = new double[x.Count(), 1];

            if (x.Length != y.Length) {
                throw new ArgumentException("x and y array lengths do not match!");
            }

            // copy y matrix
            for (int i = 0; i < y.Count(); i++) {
                matrixY[i, 0] = y[i];
            }

            // create the X matrix
            for (int row = 0; row < x.Count(); row++) {
                double nVal = 1.0f;
                for (int col = 0; col < order; col++) {
                    matrixX[row, col] = nVal;
                    nVal *= x[row];
                }
            }

            var matrixXt = matrixX.Transpose();
            var matrixXtX = matrixXt.Product(matrixX);
            var matrixXtY = matrixXt.Product(matrixY);

            var lu = new LUDecomposition(matrixXtX);
            Coeff = lu.Solve(matrixXtY).GetColumn(0).ToArray();
        }

        /// <summary>
        /// Calculates the value of a polynomial of degree n evaluated at x. The input argument 
        /// pCoeff is a vector of length n+1 whose elements are the coefficients in incremental 
        /// powers of the polynomial to be evaluated.
        /// </summary>
        /// <param name="x">Array of x values</param>
        /// <returns>Array of fitted y values</returns>
        public double[] Fit(double[] x) {
            double[] y = new double[x.Length];
            int pos = 0;

            foreach (double xval in x) {
                double xcoeff = 1;
                foreach (double coeffval in Coeff) {
                    // multiply current x by a coefficient
                    y[pos] += coeffval * xcoeff;
                    // power up the X
                    xcoeff *= xval;
                }
                pos++;
            }

            return y;
        }
    }
}
