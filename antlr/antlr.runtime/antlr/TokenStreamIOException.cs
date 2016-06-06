using System;
using IOException = System.IO.IOException;

namespace antlr
{
    /*ANTLR Translator Generator
    * Project led by Terence Parr at http://www.jGuru.com
    * Software rights: http://www.antlr.org/license.html
    *
    * $Id:$
    */

    //
    // ANTLR C# Code Generator by Micheal Jordan
    //                            Kunle Odutola       : kunle UNDERSCORE odutola AT hotmail DOT com
    //                            Anthony Oguntimehin
    //
    // With many thanks to Eric V. Smith from the ANTLR list.
    //

    /*
    * Wraps an IOException in a TokenStreamException
    */
#if FEATURE_SERIALIZATION
    [Serializable]
#endif
    public class TokenStreamIOException : TokenStreamException
    {
        public IOException io;
        /*
        * TokenStreamIOException constructor comment.
        * @param s java.lang.String
        */
        public TokenStreamIOException(IOException io)
            : base(io.Message)
        {
            this.io = io;
        }
    }
}