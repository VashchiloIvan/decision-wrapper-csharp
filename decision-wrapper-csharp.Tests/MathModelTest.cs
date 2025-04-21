using System;
using MultiCriteriaCsharpApi;
using NUnit.Framework;

[TestFixture]
public class MathModelTests
{
    [Test]
    public void Test_ToString()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, 0.2, 0.3 }),
            new EstimateVector("vector 2", new Marks() { 0.4, 0.5, 0.6 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MAXIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);
        
        var expectedString = "[0.100000, 0.200000, 0.300000] \n[0.400000, 0.500000, 0.600000] ";
        
        Assert.That(expectedString.Equals(model.ToString()));
    }

    [Test]
    public void Test_IsValid_True()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, 0.2, 0.3 }),
            new EstimateVector("vector 2", new Marks() { 0.4, 0.5, 0.6 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MAXIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);

        Assert.That(model.isValid());
    }

    [Test]
    public void Test_IsValid_False()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, 0.2 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MAXIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);

        Assert.That(model.isValid() == false);
    }

    [Test]
    public void Test_IsNormalized_True()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, 0.2, 0.3 }),
            new EstimateVector("vector 2", new Marks() { 0.4, 0.5, 0.6 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MAXIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);

        Assert.That(model.isNormalized());
    }

    [Test]
    public void Test_IsNormalized_False()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, -2, 0.3 }),
            new EstimateVector("vector 2", new Marks() { 4, 0.5, 0.6 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MAXIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);

        Assert.That(model.isNormalized() == false);
    }

    [Test]
    public void Test_SumByCriteria()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, 0.2, 0.3 }),
            new EstimateVector("vector 2", new Marks() { 0.4, 0.5, 0.6 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MAXIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);

        Assert.That(Math.Abs(0.5 - model.sumByCriteria(0)) < 0.000001);
        Assert.That(Math.Abs(0.7 - model.sumByCriteria(1)) < 0.000001);
        Assert.That(Math.Abs(0.9 - model.sumByCriteria(2)) < 0.000001);
    }

    [Test]
    public void Test_MinByCriteria()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, 0.2, 0.3 }),
            new EstimateVector("vector 2", new Marks() { 0.4, 0.5, 0.6 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MAXIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);

        Assert.That(Math.Abs(0.1 - model.minByCriteria(0)) < 0.000001);
        Assert.That(Math.Abs(0.2 - model.minByCriteria(1)) < 0.000001);
        Assert.That(Math.Abs(0.3 - model.minByCriteria(2)) < 0.000001);
    }

    [Test]
    public void Test_MaxByCriteria()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, 0.2, 0.3 }),
            new EstimateVector("vector 2", new Marks() { 0.4, 0.5, 0.6 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MAXIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);

        Assert.That(Math.Abs(0.4 - model.maxByCriteria(0)) < 0.000001);
        Assert.That(Math.Abs(0.5 - model.maxByCriteria(1)) < 0.000001);
        Assert.That(Math.Abs(0.6 - model.maxByCriteria(2)) < 0.000001);
    }

    [Test]
    public void Test_DeleteEstimateVector()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, 0.2, 0.3 }),
            new EstimateVector("vector 2", new Marks() { 0.4, 0.5, 0.6 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MAXIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MAXIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);

        model.deleteEstimateVector(1);
        Assert.That(1 == model.getEstimateVectorList().Count);
    }
}