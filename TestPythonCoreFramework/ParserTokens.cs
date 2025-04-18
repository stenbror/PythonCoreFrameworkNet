﻿using PythonCoreFramework.Parser.Tokens.Delimiters;
using PythonCoreFramework.Parser.Tokens.Keywords;
using PythonCoreFramework.Parser.Tokens.Literals;
using PythonCoreFramework.Parser.Tokens.Operators;

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
    
    [Fact]
    public void ReservedKeywordIf()
    {
        var symbol = new KeywordIfTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("IfToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordIn()
    {
        var symbol = new KeywordInTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("InToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordIs()
    {
        var symbol = new KeywordIsTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("IsToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordImport()
    {
        var symbol = new KeywordImportTokenNode(0, 6, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(6u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ImportToken( [ 0..6 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordLambda()
    {
        var symbol = new KeywordLambdaTokenNode(0, 6, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(6u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("LambdaToken( [ 0..6 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordNonlocal()
    {
        var symbol = new KeywordNonlocalTokenNode(0, 8, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(8u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("NonlocalToken( [ 0..8 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordNot()
    {
        var symbol = new KeywordNotTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("NotToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordOr()
    {
        var symbol = new KeywordOrTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("OrToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordPass()
    {
        var symbol = new KeywordPassTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("PassToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordRaise()
    {
        var symbol = new KeywordRaiseTokenNode(0, 5, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(5u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("RaiseToken( [ 0..5 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordReturn()
    {
        var symbol = new KeywordReturnTokenNode(0, 6, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(6u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ReturnToken( [ 0..6 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordTry()
    {
        var symbol = new KeywordTryTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("TryToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordWhile()
    {
        var symbol = new KeywordWhileTokenNode(0, 5, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(5u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("WhileToken( [ 0..5 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordWith()
    {
        var symbol = new KeywordWithTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("WithToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedKeywordYield()
    {
        var symbol = new KeywordYieldTokenNode(0, 5, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(5u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("YieldToken( [ 0..5 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedSoftKeywordMatch()
    {
        var symbol = new KeywordMatchTokenNode(0, 5, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(5u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("MatchToken( [ 0..5 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedSoftKeywordCase()
    {
        var symbol = new KeywordCaseTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("CaseToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedSoftKeywordType()
    {
        var symbol = new KeywordTypeTokenNode(0, 4, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(4u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("TypeToken( [ 0..4 ] )", symbol.ToString());
    }
    
    [Fact]
    public void ReservedSoftKeywordDefault() // '_'
    {
        var symbol = new KeywordDefaultTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("DefaultToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorPlus()
    {
        var symbol = new OperatorPlusTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("PlusToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorMinus()
    {
        var symbol = new OperatorMinusTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("MinusToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorMul()
    {
        var symbol = new OperatorMulTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("MulToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorPower()
    {
        var symbol = new OperatorPowerTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("PowerToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorDiv()
    {
        var symbol = new OperatorDivTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("DivToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorFloorDiv()
    {
        var symbol = new OperatorFloorDivTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("FloorDivToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorMatrices()
    {
        var symbol = new OperatorMatricesTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("MatricesToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorModulo()
    {
        var symbol = new OperatorModuloTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ModuloToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorShiftLeft()
    {
        var symbol = new OperatorShiftLeftTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ShiftLeftToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorShiftRight()
    {
        var symbol = new OperatorShiftRightTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ShiftRightToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorAnd()
    {
        var symbol = new OperatorAndTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("BitwiseAndToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorOr()
    {
        var symbol = new OperatorOrTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("BitwiseOrToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorXor()
    {
        var symbol = new OperatorXorTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("BitwiseXorToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorNot()
    {
        var symbol = new OperatorInvertTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("BitwiseInvertToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorAssign()
    {
        var symbol = new OperatorColonAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ColonAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorEqual()
    {
        var symbol = new OperatorEqualTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("EqualToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorNotEqual()
    {
        var symbol = new OperatorNotEqualTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("NotEqualToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorLessEqual()
    {
        var symbol = new OperatorLessEqualTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("LessEqualToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorGreaterEqual()
    {
        var symbol = new OperatorGreaterEqualTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("GreaterEqualToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorLess()
    {
        var symbol = new OperatorLessTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("LessToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void OperatorGreater()
    {
        var symbol = new OperatorGreaterTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("GreaterToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterLeftParen()
    {
        var symbol = new DelimiterLeftParenTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("LeftParenToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterRightParen()
    {
        var symbol = new DelimiterRightParenTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("RightParenToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterLeftBracket()
    {
        var symbol = new DelimiterLeftBracketTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("LeftBracketToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterRightBracket()
    {
        var symbol = new DelimiterRightBracketTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("RightBracketToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterLeftCurly()
    {
        var symbol = new DelimiterLeftCurlyTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("LeftCurlyToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterRightCurly()
    {
        var symbol = new DelimiterRightCurlyTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("RightCurlyToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterAssign()
    {
        var symbol = new DelimiterAssignTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("AssignToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterColon()
    {
        var symbol = new DelimiterColonTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ColonToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterComma()
    {
        var symbol = new DelimiterCommaTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("CommaToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterEllipsis()
    {
        var symbol = new DelimiterEllipsisTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("EllipsisToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterNot()
    {
        var symbol = new DelimiterNotTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("BitwiseNotToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterPeriod()
    {
        var symbol = new DelimiterPeriodTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("PeriodToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterSemicolon()
    {
        var symbol = new DelimiterSemicolonTokenNode(0, 1, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(1u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("SemicolonToken( [ 0..1 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterArrow()
    {
        var symbol = new DelimiterArrowTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ArrowToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterDivAssign()
    {
        var symbol = new DelimiterDivAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("DivAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterFloorDivAssign()
    {
        var symbol = new DelimiterFloorDivAssignTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("FloorDivAssignToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterMinusAssign()
    {
        var symbol = new DelimiterMinusAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("MinusAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterModuloAssign()
    {
        var symbol = new DelimiterModuloAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ModuloAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterMulAssign()
    {
        var symbol = new DelimiterMulAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("MulAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterPlusAssign()
    {
        var symbol = new DelimiterPlusAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("PlusAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterAndAssign()
    {
        var symbol = new DelimiterAndAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("BitwiseAndAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterOrAssign()
    {
        var symbol = new DelimiterOrAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("BitwiseOrAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterXorAssign()
    {
        var symbol = new DelimiterXorAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("BitwiseXorAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterMatricesAssign()
    {
        var symbol = new DelimiterMatricesAssignTokenNode(0, 2, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("MatricesAssignToken( [ 0..2 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterPowerssign()
    {
        var symbol = new DelimiterPowerAssignTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("PowerAssignToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterShiftLeftAssign()
    {
        var symbol = new DelimiterShiftLeftAssignTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ShiftLeftAssignToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void DelimiterShiftRightAssign()
    {
        var symbol = new DelimiterShiftRightAssignTokenNode(0, 3, []);
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(3u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("ShiftRightAssignToken( [ 0..3 ] )", symbol.ToString());
    }
    
    [Fact]
    public void LiteralName()
    {
        var symbol = new LiteralNameTokenNode(0, 8, [], "__init__");
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(8u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("NameToken( [ 0..8 ] : '__init__' )", symbol.ToString());
    }
    
    [Fact]
    public void LiteralNumber()
    {
        var symbol = new LiteralNumberTokenNode(0, 8, [], "1.23e-45");
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(8u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("NumberToken( [ 0..8 ] : '1.23e-45' )", symbol.ToString());
    }
    
    [Fact]
    public void LiteralStringSingle()
    {
        var symbol1 = new LiteralStringElementTokenNode(0, 15, [], "'Hello, World!'");
        var symbol2 = new LiteralStringTokenNode(0, 15, []);
        symbol2.AddElement(symbol1);
        
        Assert.Equal(0u, symbol1.Start);
        Assert.Equal(15u, symbol1.End);
        Assert.Equal([], symbol1.Trivia);
        Assert.Equal("StringElementToken( [ 0..15 ] : 'Hello, World!' )", symbol1.ToString());
        
        Assert.Equal(0u, symbol2.Start);
        Assert.Equal(15u, symbol2.End);
        Assert.Equal([], symbol2.Trivia);
        Assert.Equal("StringToken( [ 0..15 ] : [ StringElementToken( [ 0..15 ] : 'Hello, World!' ) ] )", symbol2.ToString());
    }
    
    [Fact]
    public void EndOfFile()
    {
        var symbol = new DelimiterEndOfFileTokenNode(0, [] );
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(0u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal("EndOfFileToken( [ 0 ] )", symbol.ToString());
    }
    
    [Fact]
    public void NewLineToken()
    {
        var symbol = new DelimiterNewlineTokenNode(0, 2, [], '\r','\n' );
        Assert.Equal(0u, symbol.Start);
        Assert.Equal(2u, symbol.End);
        Assert.Equal([], symbol.Trivia);
        Assert.Equal('\r', symbol.First);
        Assert.Equal('\n', symbol.Second);
        Assert.Equal("NewlineToken( [ 0..2 ] )", symbol.ToString());
    }
}