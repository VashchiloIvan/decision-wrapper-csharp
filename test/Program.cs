
namespace SWIGTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MathModel mathModel = new MathModel(new Criterias()
                {
                    new Criteria("1", CriteriaType.MINIMIZATION),
                    new Criteria("2", CriteriaType.MAXIMIZATION),
                    new Criteria("3", CriteriaType.MINIMIZATION),
                }, new EstimateVectors()
                {
                    new EstimateVector("1", new Marks() { 1, 5, 2 }),
                    new EstimateVector("2", new Marks() { -1, 4, 1 }),
                    new EstimateVector("3", new Marks() { 0, 9, 3 }),
                });
            
            Console.WriteLine(mathModel.ToString());

            Console.WriteLine();
            Normalizer normalizer = new MinMaxNormalizer();
            var mm3 = normalizer.getNormalizedMathModel(mathModel);
            Console.WriteLine(mm3.ToString());
            
            Console.WriteLine();
            Unifier unifier = new AlternativeUnifier();
            var mm2 = unifier.getUnifiedMathModel(mathModel);
            Console.WriteLine(mm2.ToString());
        }
    }
}