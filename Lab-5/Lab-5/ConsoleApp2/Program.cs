using System;

    class Rectangle
    {
        // Поля.
        int a, b;

        // Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
        public Rectangle()
        {
            a = 0;
            b = 0;
        }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        // Метод, позволяющий вывести длины сторон прямоугольника на экран.
        public override string ToString() => $"Длина сторон прямоугольника: a = {a} см, b= {b} см";

        // Метод, позволяющий рассчитать периметр прямоугольника.
        public string PerimeterCalculation()
        {
            int perimeter = 2 * (a + b);
            return $"Периметр прямоугольника: P = {perimeter}";
        }

        // Метод, позволяющий площадь прямоугольника.
        public string AreaCalculation()
        {
            int area = a + b;
            return $"Площадь прямоугольника: S = {area}";
        }

        // Свойство, позволяющее получить-установить длины сторон прямоугольника (доступное для чтения и записи);
        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
        }

        // Свойство, позволяющее установить, является ли данный прямоугольник квадратом (доступное только для чтения).
        public bool IsSquare
        {
            get
            {
                if (a == b)
                {
                    return true;
                }
                return false;
            }
        }

        // Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 – к полю b, при других значениях индекса выдается сообщение об ошибке.
        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return $"Индексу {i} соответствует сторона a, равная {a} см";
                    case 1:
                        return $"Индексу {i} соответствует сторона b, равная {b} см";
                    default:
                        return $"Индексу {i} является недействительным";
                }
            }
        }

        // Перегрузка операции ++: одновременно увеличивает значение полей a и b.
        public static Rectangle operator ++(Rectangle side) => new Rectangle(++side.a, ++side.b);

        // Перегрузка операции --: одновременно уменьшает значение полей a и b.
        public static Rectangle operator --(Rectangle side) => new Rectangle(--side.a, --side.b);

        // Перегрузка констант true и false: обращение к экземпляру класса дает значение true, 
        // если прямоугольник с заданными длинами сторон является квадратом, иначе false.
        public static bool operator true(Rectangle side) => side.IsSquare;
        public static bool operator false(Rectangle side) => side.IsSquare;

        // Перегрузка операции *: одновременно домножает поля a и b на скаляр.
        public static Rectangle operator *(Rectangle side, int scalar) => new Rectangle(side.a *= scalar, side.b *= scalar);
    }
