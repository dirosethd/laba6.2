namespace Matrix
{
    public class Class1
    {
        public class Matrix
        {
            private int[,] _elements;

            public Matrix(int[,] elements)
            {
                if (elements.GetLength(0) != elements.GetLength(1))
                {
                    throw new ArgumentException("Матрица должна быть квадратной.");
                }
                _elements = elements;
            }

            public int CalculateDiagonalProduct()
            {
                int product = 1;
                int size = _elements.GetLength(0);
                for (int i = 0; i < size; i++)
                {
                    product *= _elements[i, i];
                }
                return product;
            }
        }
    }
}