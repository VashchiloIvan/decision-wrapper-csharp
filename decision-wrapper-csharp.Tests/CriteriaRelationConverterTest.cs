using NUnit.Framework;

namespace decision_wrapper_csharp.Tests;

[TestFixture]
[TestOf(typeof(CriteriaRelationConverter))]
public class CriteriaRelationConverterTest
{
    [Test]
    public void TestToAllCriteriaRelation_FromSimpleCriteriaRelation()
    {
        // 2 < 1
        // 2 > 4
        // 2 > 3
        // 3 < 4
        // 5 < 4

        CriteriaRelation simpleCriteriaRelation = new SimpleCriteriaRelation(
            new TwoCriteriaRelationList()
            {
                new TwoCriteriaRelation(2, CriteriaConstraint.Less, 1),
                new TwoCriteriaRelation(2, CriteriaConstraint.More, 4),
                new TwoCriteriaRelation(2, CriteriaConstraint.More, 3),
                new TwoCriteriaRelation(4, CriteriaConstraint.Less, 3),
                new TwoCriteriaRelation(5, CriteriaConstraint.Less, 4),
            }, 5);

        AllCriteriaRelation relation = CriteriaRelationConverter.convertToAllCriteriaRelation(simpleCriteriaRelation, verbose: true);
        var idSequence = relation.getIdSequence();
        var expectedSequence = new IntList() { 1, 2, 3, 4, 5 };

        for (int i = 0; i < 5; i++)
        {
            Assert.That(idSequence[i] == expectedSequence[i]);
        }
    }
}