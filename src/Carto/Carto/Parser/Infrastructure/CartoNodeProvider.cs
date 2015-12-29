﻿//==========================================================================================
//
//		MapSurfer.Styling.Formats.CartoCSS.Parser.Infrastructure
//		Copyright (c) 2008-2015, MapSurfer.NET
//
//    Authors: Maxim Rylov
// 
//    A C# port of the carto library written by Mapbox (https://github.com/mapbox/carto/)
//    and released under the Apache License Version 2.0.
//
//==========================================================================================
using System.Collections.Generic;

using dotless.Core.Parser;
using dotless.Core.Importers;
using dotless.Core.Parser.Tree;
using dotless.Core.Parser.Infrastructure.Nodes;
using dotless.Core.Parser.Infrastructure;

using MapSurfer.Styling.Formats.CartoCSS.Parser.Tree;

namespace MapSurfer.Styling.Formats.CartoCSS.Parser.Infrastructure
{
  internal class CartoNodeProvider : INodeProvider
  {
    public Element Element(Combinator combinator, Node value, NodeLocation location)
    {
      return new CartoElement(combinator, value) { Location = location };
    }

    public Combinator Combinator(string value, NodeLocation location)
    {
      return new Combinator(value) { Location = location };
    }
    
    public Selector Selector(NodeList<Element> elements, NodeLocation location)
    {
    	// TODO
    	throw new System.NotImplementedException();
    }
    
    public Selector Selector(NodeList<Element> elements, NodeLocation location, Env env)
    {
      return new CartoSelector(elements, env) { Location = location };
    }

    public dotless.Core.Parser.Tree.Rule Rule(string name, Node value, NodeLocation location)
    {
      return new CartoRule(name, value) { Location = location };
    }

    public dotless.Core.Parser.Tree.Rule Rule(string name, Node value, bool variadic, NodeLocation location)
    {
      return new CartoRule(name, value, variadic) { Location = location };
    }

    public Ruleset Ruleset(NodeList<Selector> selectors, NodeList rules, NodeLocation location)
    {
      return new Ruleset(selectors, rules) { Location = location };
    }

    public Alpha Alpha(Node value, NodeLocation location)
    {
      return new Alpha(value) { Location = location };
    }

    public Call Call(string name, NodeList<Node> arguments, NodeLocation location)
    {
      return new Call(name, arguments) { Location = location };
    }

    public Color Color(string rgb, NodeLocation location)
    {
      return new Color(rgb) { Location = location };
    }

    public Keyword Keyword(string value, NodeLocation location)
    {
      return new Keyword(value) { Location = location };
    }

    public Number Number(string value, string unit, NodeLocation location)
    {
      return new Number(value, unit) { Location = location };
    }

    public Shorthand Shorthand(Node first, Node second, NodeLocation location)
    {
      return new Shorthand(first, second) { Location = location };
    }

    public Variable Variable(string name, NodeLocation location)
    {
      return new Variable(name) { Location = location };
    }

    public Url Url(Node value, IImporter importer, NodeLocation location)
    {
      return new Url(value, importer) { Location = location };
    }

    public Script Script(string script, NodeLocation location)
    {
      return new Script(script) { Location = location };
    }

    public MixinCall MixinCall(NodeList<Element> elements, List<NamedArgument> arguments, bool important, NodeLocation location)
    {
      return new MixinCall(elements, arguments, important) { Location = location };
    }

    public MixinDefinition MixinDefinition(string name, NodeList<dotless.Core.Parser.Tree.Rule> parameters, NodeList rules, Condition condition, bool variadic, NodeLocation location)
    {
      return new MixinDefinition(name, parameters, rules, condition, variadic) { Location = location };
    }

    public Import Import(Url path, Value features, ImportOptions option, NodeLocation location)
    {
      return new Import(path, features, option) { Location = location };
    }

    public Import Import(Quoted path, Value features, ImportOptions option, NodeLocation location)
    {
      return new Import(path, features, option) { Location = location };
    }

    public Directive Directive(string name, string identifier, NodeList rules, NodeLocation location)
    {
      return new Directive(name, identifier, rules) { Location = location };
    }

    public Media Media(NodeList rules, Value features, NodeLocation location)
    {
      return new Media(features, rules) { Location = location };
    }

    public KeyFrame KeyFrame(NodeList identifier, NodeList rules, NodeLocation location)
    {
      return new KeyFrame(identifier, rules) { Location = location };
    }

    public Directive Directive(string name, Node value, NodeLocation location)
    {
      return new Directive(name, value) { Location = location };
    }

    public Expression Expression(NodeList expression, NodeLocation location)
    {
      return new Expression(expression) { Location = location };
    }

    public Value Value(IEnumerable<Node> values, string important, NodeLocation location)
    {
      return new Value(values, important) { Location = location };
    }

    public Operation Operation(string operation, Node left, Node right, NodeLocation location)
    {
      return new Operation(operation, left, right) { Location = location };
    }

    public Assignment Assignment(string key, Node value, NodeLocation location)
    {
      return new Assignment(key, value);
    }

    public Comment Comment(string value, NodeLocation location)
    {
      return new Comment(value) { Location = location };
    }

    public TextNode TextNode(string contents, NodeLocation location)
    {
      return new TextNode(contents) { Location = location };
    }

    public Quoted Quoted(string value, string contents, bool escaped, NodeLocation location)
    {
      return new Quoted(value, contents, escaped) { Location = location };
    }

    public Paren Paren(Node value, NodeLocation location)
    {
      return new Paren(value) { Location = location };
    }

    public Condition Condition(Node left, string operation, Node right, bool negate, NodeLocation location)
    {
      return new Condition(left, operation, right, negate) { Location = location };
    }
#if CSS3EXPERIMENTAL
        public RepeatEntity RepeatEntity(Node value, Node repeatCount, int index)
        {
            return new RepeatEntity(value, repeatCount) { Location = location };
        }
#endif

    public Extend Extend(List<Selector> exact, List<Selector> partial, NodeLocation location)
    {
      return new Extend(exact, partial) { Location = location };
    }

    public GuardedRuleset GuardedRuleset(NodeList<Selector> selectors, NodeList rules, Condition condition, NodeLocation location)
    {
      return new GuardedRuleset(selectors, rules, condition) { Location = location };
    }

    public Node Attribute(Node key, Node op, Node val, NodeLocation location)
    {
      return new Attribute(key, op, val) { Location = location };
    }

    public CssFunction CssFunction(string name, Node value, NodeLocation location)
    {
      return new CssFunction() { Name = name, Value = value, Location = location };
    }

  }
}