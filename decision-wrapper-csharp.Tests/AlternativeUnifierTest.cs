using NUnit.Framework;
using System.Collections.Generic;
using MultiCriteriaCsharpApi;

[TestFixture]
public class AlternativeUnifierTests
{
    [Test]
    public void TestUnifiedMathModel_WithMinimizationCriteria_ReturnsUnifiedModel()
    {
        var estimateVectorList = new EstimateVectors
        {
            new EstimateVector("vector 1", new Marks() { 0.1, -0.2, 0.3 }),
            new EstimateVector("vector 2", new Marks() { -0.4, 0.5, 0.6 }),
            new EstimateVector("vector 3", new Marks() { 4, -5, -10 }),
        };
        
        var criteriaList = new Criterias()
        {
            new Criteria("1", CriteriaType.MINIMIZATION), 
            new Criteria("2", CriteriaType.MAXIMIZATION), 
            new Criteria("3", CriteriaType.MINIMIZATION),
        };
        var model = new MathModel(criteriaList, estimateVectorList);

        Unifier unifier = new AlternativeUnifier();
        var unified = unifier.getUnifiedMathModel(model);
        
        Assert.That(unified.getCriteriaList()[0].getType() == CriteriaType.MAXIMIZATION);
        Assert.That(unified.getCriteriaList()[2].getType() == CriteriaType.MAXIMIZATION);

        var idx = 0;
        foreach (EstimateVector estimateVector in unified.getEstimateVectorList())
        {
            var markIdx = 0;
            var marks = estimateVector.getMarks();
            foreach (var mark in marks)
            {
                Assert.That(mark / estimateVectorList[idx].getMarks()[markIdx] == (markIdx == 1 ? 1 : -1));
                markIdx++;
            }
            
            idx++;
        }
    }
}