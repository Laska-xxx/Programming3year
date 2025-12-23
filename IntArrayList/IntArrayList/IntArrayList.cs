namespace RepeatingOOP
{
    internal class IntArrayList
    {
        private int[] _buffer;
        private int _count;
        private int _capacity;
        private readonly int _defaultCapacity = 2;

        public int Count
        {
            get { return _count; }
        }
        public int Capacity
        { 
            get { return _capacity; } 
        }

        public int this[int index]
        {
            get => _buffer[index];
            set => _buffer[index] = value;
        }

        public IntArrayList()
        {
            _capacity = _defaultCapacity;
            _buffer = new int[_capacity];
            _count = 0;
        }

        public IntArrayList(int capacitySize)
        {
            if (capacitySize < 0)
            {
                capacitySize = _defaultCapacity;
            }

            _capacity = capacitySize;
            _buffer = new int[_capacity];
            _count = 0;
        }

        public void PushBack(int value)
        {
            if (_count == _capacity)
            {
                ResizeBuffer(_count * 2);
            }

            _buffer[_count] = value;
            _count++;
        }

        public void PopBack()
        {
            if (_count > 0)
            {
                _count--;
            }
        }

        public bool TryInsert(int index, int value)
        {
            if (index < 0 || index > _count)
            {
                return false;
            }

            if (index == _count)
            {
                PushBack(value);
                return true;
            }

            if (_count == _capacity)
            {
                ResizeBuffer(_count * 2);
            }

            for (int i = _count; i > index; i--)
            {
                _buffer[i] = _buffer[i - 1];
            }

            _buffer[index] = value;
            _count++;
            return true;
        }

        public bool TryErase(int index)
        {
            if (index < 0 || index >= _count)
            {
                return false;
            }

            for (int i = index; i < _count - 1; i++)
            {
                _buffer[i] = _buffer[i + 1];
            }

            _count--;
            return true;
        }

        public bool TryGetAt(int index, out int result)
        {
            if (index < 0 || index >= _count)
            {
                result = 0;
                return false;
            }

            result = _buffer[index];
            return true;
        }

        public void Clear()
        {
            _count = 0;
        }

        public bool TryForceCapacity(int newCapacity)
        {
            if (newCapacity < 0)
            {
                return false;
            }

            if (newCapacity != _capacity)
            {
                ResizeBuffer(newCapacity);

                if (_count > _capacity)
                {
                    _count = _capacity;
                }
            }

            return true;
        }

        public int Find(int value)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_buffer[i] == value)
                {
                    return i;
                }
                   
            }

            return -1;
        }

        private void ResizeBuffer(int newCapacity)
        {
            int[] newBuffer = new int[newCapacity];

            int elementsToCopy = Math.Min(_count, newCapacity);
            for (int i = 0; i < elementsToCopy; i++)
            {
                newBuffer[i] = _buffer[i];
            }

            _buffer = newBuffer;
            _capacity = newCapacity;
        }

    }
}
/*Закрытый массив чисел типа int - буфер для хранения чисел в массиве.
- Текущее хранимое количество элементов.
- Реальный текущий размер буфера
- Закрытое поле только для чтения, обозначающее размер буфера по умолчанию, равно 2;
- Свойство только для чтения Count, возвращающее размер
- Свойство только для чтения Capacity, возвращающее реальный размер буфера.
- Открытый индексатор, позволяющий записать/считать значение буфера по индексу без проверки диапазона.
- Конструктор без параметров, создающий буфер размера по умолчанию.
- Конструктор с 1 параметром типа int, явно задающим размер создаваемого буфера;
- Метод void PushBack(int value), добавляющий число в конец списка. Если буфер оказывается слишком мал, 
    чтобы добавить в него элемент, необходимо пересоздать буфер в 2 раза большего размера, 
    скопировать из старого буфера все хранившиеся элементы в новый и добавить value в конец;
- Метод void PopBack(), удаляющий последний элемент из буфера. Если буфер уже пустой, метод ничего не делает;
- Метод bool TryInsert(int index, int value), вставляет значение value на позицию index при условии, 
    что index <= размеру (если index равен размеру, метод эквивалентен вызову PushBack()). 
    Возвращает true в случае успеха вставки и false в противном случае.
- Метод bool TryErase(int index), удаляющий из массива элемент с указанным индексом. Возвращает false, 
    если элемента с таким индексом нет или true в случае успеха выполнения операции.
- Метод bool TryGetAt(int index, out int result), пытающийся получить значение по индексу. 
    Если индекс оказывается за границами массива, метод должен возвращать false и присваивает result 0, 
    иначе возвращается true и в result записывается значение, находившееся по данному индексу.
- Открытый метод void Clear(), обнуляющий количество хранимых элементов буфера.
- Открытый метод bool TryForceCapacity(int newCapacity), явно изменяющий размер буфера на заданное          
    значение и пересоздающий буфер указанного размера. Операция не должна быть успешной, 
    если newCapacity - отрицательное, при этом возвращается false. В ином случае размер буфера меняется и 
    возвращается true, причём в случае увеличения размеров буфера реальное количество элементов не меняется.
- Открытый метод int Find(int value), который выполняет поиск индекса первого элемента, равного value. 
    Если такого элемента нет, метод возвращает -1.
C#*/