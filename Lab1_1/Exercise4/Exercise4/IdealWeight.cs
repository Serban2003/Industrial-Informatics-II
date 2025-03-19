namespace Exercise4
{
    internal class IdealWeight
    {
        Double height;
        Double age;
        Char gender;

        public IdealWeight(Double height, Double age, Char gender)
        {
            this.height = height;
            this.age = age;
            this.gender = gender;
        }

        public Double calculateIdealWeightForMen()
        {
            return Math.Round(height - 100 - ((height - 150) / 4) + ((age - 20) / 4), 2);
        }

        public Double calculateIdealWeightForWomen()
        {
            return Math.Round(height - 100 - ((height - 150) / 2.5) + ((age - 20) / 6), 2);
        }

        public void displayIdealWeight()
        {
            if (gender == 'f')
                Console.WriteLine($"Ideal weight: {calculateIdealWeightForWomen()}kg");
            else if (gender == 'm')
                Console.WriteLine($"Ideal weight: {calculateIdealWeightForMen()}kg");
        }
    }
}
