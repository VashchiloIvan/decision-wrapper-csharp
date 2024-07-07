using NUnit.Framework;

public class MinMaxNormalizerTests
{
    [Test]
    public void GetNormalizedMathModel_SimpleTest()
    {
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION),
            new Criteria("2", CriteriaType.MAXIMIZATION),
        };

        var estimateVectors = new EstimateVectors()
        {
            new EstimateVector("Vector1", new Marks() { 1.0, 1.0 }),
            new EstimateVector("Vector1", new Marks() { 2.0, 2.0 }),
            new EstimateVector("Vector1", new Marks() { 5.0, -10.0 }),
            new EstimateVector("Vector1", new Marks() { 2.0, 0.0 }),
            new EstimateVector("Vector1", new Marks() { 4.0, 11.0 }),
            new EstimateVector("Vector2", new Marks() { 3.0, 10.0 }),
        };

        var originalModel = new MathModel(criteriaList, estimateVectors);
        Normalizer normalizer = new MinMaxNormalizer();

        var normalizedMathModel = normalizer.getNormalizedMathModel(originalModel);
        Assert.That(normalizedMathModel.isNormalized());
    }
}