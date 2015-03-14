
namespace DefineClasses
{
    //task 1
    public class Display
    {
        private int size;
        private int numberOfColors;

        //task 2
        public Display()
        {

        }
        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        //task 5
        public int Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            private set
            {
                this.numberOfColors = value;
            }
        }

    

    }
}
