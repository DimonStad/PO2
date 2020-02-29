using Xunit;
using System.IO;
using System;
using _1_Lab;

public class UnitTest1{

    #region Field
    /// <summary>
    /// The class field Menu.
    /// </summary>
    /// <returns></returns>
    private Menu menu =  new Menu();
    #endregion
    
    #region Input and output menu tests

    /// <summary>
    /// Test for incorrect input. Test 1.
    /// </summary>
    [Fact]
    public void TestMethodIncorrectInput1()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Start("qwe");
                string excepted = $"";
                Assert.Equal(excepted, sw.ToString());
            }
        }
    
    /// <summary>
    /// Test for incorrect input. Test 2.
    /// </summary>
    [Fact]
    public void TestMethodIncorrectInput2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Start("dkjfgnkjdfngndkj + kdjfgnjkdnfgn - jdkfgnjkdnfgnjdf");
                string excepted = $"";
                Assert.Equal(excepted, sw.ToString());
            }
        }

    /// <summary>
    /// Test for correct input. Test 1.
    /// </summary>
    [Fact]
        public void TestMethodCorrectInput1()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Start("sqr");
                string excepted = $"sqr(0) = 0{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());
            }
        }


    /// <summary>
    /// Test for correct input. Test 2.
    /// </summary>
    [Fact]
    public void TestMethodCorrectInput2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Start("sqrt");
                string excepted = $"sqrt(0) = 0{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());
            }
        }


    /// <summary>
    /// Test for correct input. Test 3.
    /// </summary>
    [Fact]
    public void TestMethodCorrectInput3()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Start("help");
                string excepted = $"cls - clear all screen.{Environment.NewLine}" +
                                  $"stop - close programm.{Environment.NewLine}" +
                                  $"expression of the form: x + y ; x - y ; x * y ; x / y ; sqrt ; sqr ; abs ; sin ; cos ; tan ; exp ; sqrt x ; sqr x ; abs x ; sin x ; cos x ; tan x ; exp x.\n{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());
            }
        }
    
    /// <summary>
    /// Test for correct input. Test 4.
    /// </summary>
    [Fact]
    public void TestMethodCorrectInput4()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                menu.Start("2 + 2");
                string excepted = $"2 + 2 = 4{Environment.NewLine}";
                Assert.Equal(excepted, sw.ToString());
            }
        }
    
    #endregion
}