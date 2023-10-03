using Automobile_Class;

namespace Fine_Class
{
    public class Fine
    {
        private string intruder;
        private int fineSum;
        private bool status;

        public Fine(Automobile car, int fineSum) 
        { 
            intruder = car.Owner;
            this.fineSum = fineSum;
            status = false;
        }

        public int FineSum { get {  return fineSum; } }
        public bool Status { get { return status; } }
        public string Intruder { get { return intruder; } }   

        public void ChangeStatus()
        {
            status = true;
        }
    }
}
