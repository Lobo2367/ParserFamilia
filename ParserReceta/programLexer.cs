//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\kingd\OneDrive\Escritorio\Entrega Lab Construcción Grupal #2\program.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class programLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		PLUS_SIGN=1, DEATH_SIGN=2, OPEN_CURLY=3, CLOSE_CURLY=4, COMMA=5, NAME=6, 
		WS=7, TAB=8, NEW_LINE=9, START_LINE=10;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"PLUS_SIGN", "DEATH_SIGN", "OPEN_CURLY", "CLOSE_CURLY", "COMMA", "NAME", 
		"WS", "TAB", "NEW_LINE", "START_LINE"
	};


	public programLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public programLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'+'", "'#'", "'{'", "'}'", "','", null, "' '", "'\t'", "'\n'", 
		"'\r'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PLUS_SIGN", "DEATH_SIGN", "OPEN_CURLY", "CLOSE_CURLY", "COMMA", 
		"NAME", "WS", "TAB", "NEW_LINE", "START_LINE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "program.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static programLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\f', '\x36', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x6', '\a', '#', '\n', '\a', '\r', '\a', '\xE', '\a', 
		'$', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x2', '\x2', '\f', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', 
		'\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', 
		'\f', '\x3', '\x2', '\x3', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x2', 
		'\x36', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x3', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x5', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\a', '\x1B', '\x3', '\x2', '\x2', '\x2', '\t', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x1F', '\x3', '\x2', '\x2', '\x2', '\r', '\"', '\x3', 
		'\x2', '\x2', '\x2', '\xF', '&', '\x3', '\x2', '\x2', '\x2', '\x11', '*', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '.', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\a', '-', '\x2', 
		'\x2', '\x18', '\x4', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', '\a', 
		'%', '\x2', '\x2', '\x1A', '\x6', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'\x1C', '\a', '}', '\x2', '\x2', '\x1C', '\b', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '\x1E', '\a', '\x7F', '\x2', '\x2', '\x1E', '\n', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', ' ', '\a', '.', '\x2', '\x2', ' ', '\f', '\x3', 
		'\x2', '\x2', '\x2', '!', '#', '\t', '\x2', '\x2', '\x2', '\"', '!', '\x3', 
		'\x2', '\x2', '\x2', '#', '$', '\x3', '\x2', '\x2', '\x2', '$', '\"', 
		'\x3', '\x2', '\x2', '\x2', '$', '%', '\x3', '\x2', '\x2', '\x2', '%', 
		'\xE', '\x3', '\x2', '\x2', '\x2', '&', '\'', '\a', '\"', '\x2', '\x2', 
		'\'', '(', '\x3', '\x2', '\x2', '\x2', '(', ')', '\b', '\b', '\x2', '\x2', 
		')', '\x10', '\x3', '\x2', '\x2', '\x2', '*', '+', '\a', '\v', '\x2', 
		'\x2', '+', ',', '\x3', '\x2', '\x2', '\x2', ',', '-', '\b', '\t', '\x2', 
		'\x2', '-', '\x12', '\x3', '\x2', '\x2', '\x2', '.', '/', '\a', '\f', 
		'\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', '\x31', 
		'\b', '\n', '\x2', '\x2', '\x31', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'\x32', '\x33', '\a', '\xF', '\x2', '\x2', '\x33', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\x34', '\x35', '\b', '\v', '\x2', '\x2', '\x35', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x4', '\x2', '$', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}