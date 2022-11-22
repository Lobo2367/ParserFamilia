grammar program;

program: OPEN_CURLY family+ CLOSE_CURLY EOF;

family: couple sons | couple | single;

single: person COMMA*;

couple: person PLUS_SIGN person;

sons: OPEN_CURLY family+ CLOSE_CURLY COMMA*;

person: NAME DEATH_SIGN | NAME;

PLUS_SIGN: '+';

DEATH_SIGN: '#';

OPEN_CURLY: '{';
CLOSE_CURLY: '}';

COMMA: ',';

NAME: [a-zA-Z]+;

WS: ' ' -> skip;
TAB: '\t' -> skip;
NEW_LINE: '\n' -> skip;
START_LINE: '\r' -> skip;