namespace Home5 
{
    public class ListBook
    {
        public Book[] listBook { get; set; }
        public int Length { get; set; }

        public ListBook(){
            Length = 0;
        }

        public this[int index](){
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

    }
}