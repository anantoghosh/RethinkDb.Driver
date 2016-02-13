












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Filter : ReqlExpr {

    
    
    
/// <summary>
/// <para>Get all the documents for which the given predicate is true.</para>
/// <para><code>filter</code> can be called on a sequence, selection, or a field containing an array of
/// elements. The return type is the same as the type on which the function was called on.</para>
/// <para>The body of every filter is wrapped in an implicit <code>.default(false)</code>, which means that
/// if a non-existence errors is thrown (when you try to access a field that does not exist
/// in a document), RethinkDB will just ignore the document.
/// The <code>default</code> value can be changed by passing an object with a <code>default</code> field.
/// Setting this optional argument to <code>r.error()</code> will cause any non-existence errors to
/// return a <code>RqlRuntimeError</code>.</para>
/// </summary>
/// <example><para>Example: Get all the users that are 30 years old.</para>
/// <code>r.table('users').filter({age: 30}).run(conn, callback)
/// </code></example>
        public Filter (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Get all the documents for which the given predicate is true.</para>
/// <para><code>filter</code> can be called on a sequence, selection, or a field containing an array of
/// elements. The return type is the same as the type on which the function was called on.</para>
/// <para>The body of every filter is wrapped in an implicit <code>.default(false)</code>, which means that
/// if a non-existence errors is thrown (when you try to access a field that does not exist
/// in a document), RethinkDB will just ignore the document.
/// The <code>default</code> value can be changed by passing an object with a <code>default</code> field.
/// Setting this optional argument to <code>r.error()</code> will cause any non-existence errors to
/// return a <code>RqlRuntimeError</code>.</para>
/// </summary>
/// <example><para>Example: Get all the users that are 30 years old.</para>
/// <code>r.table('users').filter({age: 30}).run(conn, callback)
/// </code></example>
        public Filter (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Get all the documents for which the given predicate is true.</para>
/// <para><code>filter</code> can be called on a sequence, selection, or a field containing an array of
/// elements. The return type is the same as the type on which the function was called on.</para>
/// <para>The body of every filter is wrapped in an implicit <code>.default(false)</code>, which means that
/// if a non-existence errors is thrown (when you try to access a field that does not exist
/// in a document), RethinkDB will just ignore the document.
/// The <code>default</code> value can be changed by passing an object with a <code>default</code> field.
/// Setting this optional argument to <code>r.error()</code> will cause any non-existence errors to
/// return a <code>RqlRuntimeError</code>.</para>
/// </summary>
/// <example><para>Example: Get all the users that are 30 years old.</para>
/// <code>r.table('users').filter({age: 30}).run(conn, callback)
/// </code></example>
        public Filter (Arguments args, OptArgs optargs)
         : base(TermType.FILTER, args, optargs) {
        }


    



    
///<summary>
/// "default": "T_EXPR"
///</summary>
        public Filter this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.FromMap(this.OptArgs).with(optArgs);
        
                return new Filter (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "default": "T_EXPR"
///</summary>
    public Filter this[OptArgs optArgs] {
        get
        {
            var newOptargs = OptArgs.FromMap(this.OptArgs).with(optArgs);
    
            return new Filter (this.Args, newOptargs);
        }
    }
    
///<summary>
/// "default": "T_EXPR"
///</summary>
        public Filter optArg(string key, object val){
            
            var newOptargs = OptArgs.FromMap(this.OptArgs).with(key, val);
        
            return new Filter (this.Args, newOptargs);
        }


    

    


    
    }
}
