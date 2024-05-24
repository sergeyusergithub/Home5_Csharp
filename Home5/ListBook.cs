namespace Home5 
{
    public class ListBook
    {
        private Book[] listBook;
        public int Length { get; set; }

        // индексатор для списка
        public Book this[int index]{
            get 
            {

                if (index >= 0 && index < Length){
                    return listBook[index];
                } 
                
                 throw new IndexOutOfRangeException();
                
            }

            set
            {
                listBook[index] = value;

            }
        }

        // добавляет элемент в конец списка
        public void Add(Book obj){
            Length++;
            Book[] tmp = new Book[Length];
            for(int i = 0; i < Length - 1; i++){
                tmp[i] = listBook[i];
            }
            tmp[Length - 1] = obj;
            listBook = tmp;
        }

        // добавляем элемент в конец списка оператором +
        public static ListBook operator+(ListBook ls,Book obj)
        {
            ls.Add(obj);
            return ls;
        }

        // удаляет выбранный элемент из списка
        public void Remove(int index) {
            if(index >= 0 && index < Length)
            {
                Length--;
                int count = 0;
                Book[] tmp = new Book[Length];
                for(int i = 0; i < Length + 1; i++){
                    if (i != index)
                    {
                        tmp[count] = listBook[i];
                        count += 1;
                    }
                    
                }
                listBook = tmp;

            } else
            {
                throw new IndexOutOfRangeException();
            }
        }

        // перегрузка операции сравнения == определяет есть ли данная книга в списке
        public static bool operator==(ListBook ls,Book bk){
            for(int i = 0; i < ls.Length; i++){
                if(ls[i] == bk){
                    return true;
                }
            }
            return false;
        }

        // перегрузка операции сравнения != определяет есть ли данная книга в списке
        public static bool operator!=(ListBook ls,Book bk)
        {
            for(int i = 0; i < ls.Length; i++){
                if(ls[i] == bk){
                    break;
                } else 
                {
                    return true;
                }
            }
            return false;

        }

        // метод вывода содержимого всего списка
        public void Print()
        {
            for(int i = 0; i < Length; i++){
                listBook[i].Print();
            }
        }

    }
}