namespace MeasurementsLib
{
    public class Measurement
    {
        public int Id { get; set; }
        public int Ppm {  get; set; }

        public Measurement(int id, int ppm)
        {
            Id = id;
            Ppm = ppm;
            ValidatePpm();
        }

        public void ValidatePpm()
        {

            

            if (Ppm < 0)
            {
                throw new ArgumentOutOfRangeException("Ppm cannot be less than or equal to zero");
            }

        }
    }

    
}
