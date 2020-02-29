using Xunit;
using _1_Lab;
using System;

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
    public void TestMethodSum(){
        excepted = 4;
        calculate.RES = 2;
        Assert.Equal(excepted, calculate.Sum(2));
    }
    
    /// <summary>
    /// Diff method test.
    /// </summary>
    [Fact]
    public void TestMethodDiff(){
        excepted = 2;
        calculate.RES = 4;
        Assert.Equal(excepted, calculate.Diff(2));
    }

    /// <summary>
    /// Div method test.
    /// </summary>
    [Fact]
    public void TestMethodDiv(){
        excepted = 2;
        calculate.RES = 4;
        Assert.Equal(excepted, calculate.Division(2));
    }

    /// <summary>
    /// Mult method test.
    /// </summary>
    [Fact]
    public void TestMethodMult(){
        excepted = 8;
        calculate.RES = 2;
        Assert.Equal(excepted, calculate.Multiplication(4));
    }

    /// <summary>
    /// Sqr method test.
    /// </summary>
    [Fact]
    public void TestMethodSqr(){
        excepted = 16;
        Assert.Equal(excepted, calculate.Sqr(4));
    }

    /// <summary>
    /// Sqrt method test.
    /// </summary>
    [Fact]
    public void TestMethodSqrt(){
        excepted = 4;
        Assert.Equal(excepted, calculate.Sqrt(16));
    }

    /// <summary>
    /// Abs method test.
    /// </summary>
    [Fact]
    public void TestMethodAbs(){
        excepted = 1;
        Assert.Equal(excepted, calculate.Abs(-1));
    }

    /// <summary>
    /// Sin method test.
    /// </summary>
    [Fact]
    public void TestMethodSin(){
        excepted = Math.Sin(3);
        Assert.Equal(excepted, calculate.Sin(3));
    }

    /// <summary>
    /// Cos method test.
    /// </summary>
    [Fact]
    public void TestMethodCos(){
        excepted = Math.Cos(4);
        Assert.Equal(excepted, calculate.Cos(4));
    }

    /// <summary>
    /// Sin method test.
    /// </summary>
    [Fact]
    public void TestMethodSin2(){
        excepted = Math.Sin(30);
        Assert.Equal(excepted, calculate.Sin(30));
    }

    /// <summary>
    /// Tan method test.
    /// </summary>
    [Fact]
    public void TestMethodTan(){
        excepted = Math.Tan(4);
        Assert.Equal(excepted, calculate.Tan(4));
    }

    /// <summary>
    /// Exp method test.
    /// </summary>
    [Fact]
    public void TestMethodExp(){
        excepted = Math.Exp(6);
        Assert.Equal(excepted, calculate.Exp(6));
    }

    /// <summary>
    /// Log method test.
    /// </summary>
    [Fact]
    public void TestMethodLog(){
        excepted = Math.Log(10);
        Assert.Equal(excepted, calculate.Log(10));
    }
    #endregion
}