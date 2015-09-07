










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

    public class Limit : ReqlExpr {

    
    
    
/// <summary>
/// <para>End the sequence after the given number of elements.</para>
/// </summary>
/// <example><para>Example: Only so many can fit in our Pantheon of heroes.</para>
/// <code>r.table('marvel').orderBy('belovedness').limit(10).run(conn, callback)
/// </code></example>
        public Limit (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>End the sequence after the given number of elements.</para>
/// </summary>
/// <example><para>Example: Only so many can fit in our Pantheon of heroes.</para>
/// <code>r.table('marvel').orderBy('belovedness').limit(10).run(conn, callback)
/// </code></example>
        public Limit (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>End the sequence after the given number of elements.</para>
/// </summary>
/// <example><para>Example: Only so many can fit in our Pantheon of heroes.</para>
/// <code>r.table('marvel').orderBy('belovedness').limit(10).run(conn, callback)
/// </code></example>
        public Limit (Arguments args, OptArgs optargs)
             : this(TermType.LIMIT, args, optargs) {
        }

    protected Limit (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
