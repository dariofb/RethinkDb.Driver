










//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Le : ReqlExpr {

    
    
    
/// <summary>
/// <para>Test if the first value is less than or equal to other.</para>
/// </summary>
/// <example><para>Example: Is 2 less than or equal to 2?</para>
/// <code>r.expr(2).le(2).run(conn, callback)
/// </code></example>
        public Le (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Test if the first value is less than or equal to other.</para>
/// </summary>
/// <example><para>Example: Is 2 less than or equal to 2?</para>
/// <code>r.expr(2).le(2).run(conn, callback)
/// </code></example>
        public Le (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Test if the first value is less than or equal to other.</para>
/// </summary>
/// <example><para>Example: Is 2 less than or equal to 2?</para>
/// <code>r.expr(2).le(2).run(conn, callback)
/// </code></example>
        public Le (Arguments args, OptArgs optargs)
             : this(TermType.LE, args, optargs) {
        }

    protected Le (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
