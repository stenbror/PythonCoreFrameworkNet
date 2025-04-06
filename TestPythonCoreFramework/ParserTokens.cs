using PythonCoreFramework.Parser.Tokens.Keywords;

namespace TestPythonCoreFramework;

public class ParserTokens
{
    [Fact]
    public void ReservedKeywordFalse()
    {
        var symbol = new KeywordFalseTokenNode(0, 5, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(5u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("FalseToken( [ 0..5 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordNone()
    {
        var symbol = new KeywordNoneTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("NoneToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordTrue()
    {
        var symbol = new KeywordTrueTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("TrueToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordAnd()
    {
        var symbol = new KeywordAndTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("AndToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordAs()
    {
        var symbol = new KeywordAsTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("AsToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordAssert()
    {
        var symbol = new KeywordAssertTokenNode(0, 6, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(6u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("AssertToken( [ 0..6 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordAsync()
    {
        var symbol = new KeywordAsyncTokenNode(0, 5, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(5u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("AsyncToken( [ 0..5 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordAwait()
    {
        var symbol = new KeywordAwaitTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("AwaitToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordBreak()
    {
        var symbol = new KeywordBreakTokenNode(0, 5, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(5u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("BreakToken( [ 0..5 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordClass()
    {
        var symbol = new KeywordClassTokenNode(0, 5, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(5u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ClassToken( [ 0..5 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordContinue()
    {
        var symbol = new KeywordContinueTokenNode(0, 8, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(8u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ContinueToken( [ 0..8 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordDef()
    {
        var symbol = new KeywordDefTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("DefToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordDel()
    {
        var symbol = new KeywordDelTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("DelToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordElif()
    {
        var symbol = new KeywordElifTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ElifToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordElse()
    {
        var symbol = new KeywordElseTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ElseToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordExcept()
    {
        var symbol = new KeywordExceptTokenNode(0, 6, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(6u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ExceptToken( [ 0..6 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordFinally()
    {
        var symbol = new KeywordFinallyTokenNode(0, 7, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(7u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("FinallyToken( [ 0..7 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordFor()
    {
        var symbol = new KeywordForTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ForToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordFrom()
    {
        var symbol = new KeywordFromTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("FromToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordGlobal()
    {
        var symbol = new KeywordGlobalTokenNode(0, 6, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(6u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("GlobalToken( [ 0..6 ] )", symbol.ToString());
    }
}