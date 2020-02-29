using Xunit;
using _1_Lab;

public class UnitTest2{

    #region Field
    /// <summary>
    /// The class field Calculate.
    /// </summary>
    /// <returns></returns>
    private Calculate calculate = new Calculate();
    
    /// <summary>
    /// A field that shows what should happen.
    /// </summary>
    private double excepted = 0;
    #endregion
    
    #region Output calculate tests
    /// <summary>
    /// Sum method test.
    /// </summary>
    [Fact]
    public void TestMethodSum()
        {
            excepted = 4;
            calculate.RES = 2;
            Assert.Equal(excepted, calculate.Sum(2));
        }
    
    /// <summary>
    /// Diff method test.
    /// </summary>
    [Fact]
    public void TestMethodDiff()
        {
            excepted = 2;
            calculate.RES = 4;
            Assert.Equal(excepted, calculate.Diff(2));
        }

    /// <summary>
    /// Div method test.
    /// </summary>
    [Fact]
    public void TestMethodDiv()
        {
            excepted = 2;
            calculate.RES = 4;
            Assert.Equal(excepted, calculate.Division(2));
        }

    /// <summary>
    /// Mult method test.
    /// </summary>
    [Fact]
    public void TestMethodMult()
        {
            excepted = 8;
            calculate.RES = 2;
            Assert.Equal(excepted, calculate.Multiplication(4));
        }

    /// <summary>
    /// Sqr method test.
    /// </summary>
    [Fact]
    public void TestMethodSqr()
        {
            excepted = 16;
            Assert.Equal(excepted, calculate.Sqr(4));
        }

    /// <summary>
    /// Sqrt method test.
    /// </summary>
    [Fact]
    public void TestMethodSqrt()
        {
            excepted = 4;
            Assert.Equal(excepted, calculate.Sqrt(16));
        }

    /// <summary>
    /// Abs method test.
    /// </summary>
    [Fact]
    public void TestMethodAbs()
        {
            excepted = 1;
            Assert.Equal(excepted, calculate.Abs(-1));
        }
    #endregion
}