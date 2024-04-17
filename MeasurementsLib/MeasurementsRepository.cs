using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MeasurementsLib;


namespace MeasurementsLib
{
    public class MeasurementsRepository
    {
        List<Measurement> measurements = new List<Measurement>(); 
        public MeasurementsRepository()
        {
            Measurement measurement1 = new Measurement(1, 225);


            Measurement measurement2 = new Measurement(2, 765);


            Measurement measurement3 = new Measurement(3, 480);
            

            measurements.Add(measurement1);
            measurements.Add(measurement2);
            measurements.Add(measurement3);
           
        }

        public List<Measurement> GetAll()
        {
            //hvorfor retuner en kopi af listen og hvordan?
            return measurements.ToList(); 
        }


        public Measurement? GetById(int id)
        {

            Measurement? spfcMeasurements = measurements.Find(measurement => measurement.Id == id);

            return spfcMeasurements;
        }

        public Measurement Add(Measurement measurement)
        {
            //measurement.Id = measurement.Id++;
            int nextId = measurement.Id++;
            measurements.Add(measurement);
            return measurement;
        }

        public Measurement? Delete(int id)
        {
           
            Measurement? measurementToDelete = measurements.FirstOrDefault(m => m.Id == id);

            if (measurementToDelete != null)
            {
               
                measurements.Remove(measurementToDelete);
            }
            
            return measurementToDelete;

        }
    }
}
