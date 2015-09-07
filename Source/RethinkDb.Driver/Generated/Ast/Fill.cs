










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

    public class Fill : ReqlExpr {

    
    
    
/// <summary>
/// <para>Convert a Line object into a Polygon object. If the last point does not specify the same coordinates as the first point, <code>polygon</code> will close the polygon by connecting them.</para>
/// </summary>
/// <example><para>Example: Create a line object and then convert it to a polygon.</para>
/// <code>r.table('geo').insert({
///     id: 201,
///     rectangle: r.line(
///         [-122.423246,37.779388],
///         [-122.423246,37.329898],
///         [-121.886420,37.329898],
///         [-121.886420,37.779388]
///     )
/// }).run(conn, callback);
/// 
/// r.table('geo').get(201).update({
///     rectangle: r.row('rectangle').fill()
/// }).run(conn, callback);
/// </code></example>
        public Fill (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Convert a Line object into a Polygon object. If the last point does not specify the same coordinates as the first point, <code>polygon</code> will close the polygon by connecting them.</para>
/// </summary>
/// <example><para>Example: Create a line object and then convert it to a polygon.</para>
/// <code>r.table('geo').insert({
///     id: 201,
///     rectangle: r.line(
///         [-122.423246,37.779388],
///         [-122.423246,37.329898],
///         [-121.886420,37.329898],
///         [-121.886420,37.779388]
///     )
/// }).run(conn, callback);
/// 
/// r.table('geo').get(201).update({
///     rectangle: r.row('rectangle').fill()
/// }).run(conn, callback);
/// </code></example>
        public Fill (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Convert a Line object into a Polygon object. If the last point does not specify the same coordinates as the first point, <code>polygon</code> will close the polygon by connecting them.</para>
/// </summary>
/// <example><para>Example: Create a line object and then convert it to a polygon.</para>
/// <code>r.table('geo').insert({
///     id: 201,
///     rectangle: r.line(
///         [-122.423246,37.779388],
///         [-122.423246,37.329898],
///         [-121.886420,37.329898],
///         [-121.886420,37.779388]
///     )
/// }).run(conn, callback);
/// 
/// r.table('geo').get(201).update({
///     rectangle: r.row('rectangle').fill()
/// }).run(conn, callback);
/// </code></example>
        public Fill (Arguments args, OptArgs optargs)
             : this(TermType.FILL, args, optargs) {
        }

    protected Fill (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}
