










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

    public class Day : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return the day of a time object as a number between 1 and 31.</para>
/// </summary>
/// <example><para>Example: Return the users born on the 24th of any month.</para>
/// <code>r.table("users").filter(
///     r.row("birthdate").day().eq(24)
/// ).run(conn, callback)
/// </code></example>
        public Day (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return the day of a time object as a number between 1 and 31.</para>
/// </summary>
/// <example><para>Example: Return the users born on the 24th of any month.</para>
/// <code>r.table("users").filter(
///     r.row("birthdate").day().eq(24)
/// ).run(conn, callback)
/// </code></example>
        public Day (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return the day of a time object as a number between 1 and 31.</para>
/// </summary>
/// <example><para>Example: Return the users born on the 24th of any month.</para>
/// <code>r.table("users").filter(
///     r.row("birthdate").day().eq(24)
/// ).run(conn, callback)
/// </code></example>
        public Day (Arguments args, OptArgs optargs)
             : this(TermType.DAY, args, optargs) {
        }

    protected Day (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
