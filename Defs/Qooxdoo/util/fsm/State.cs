// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.util.fsm
{
    /// <summary>
	/// <para>Create a new state which may be added to a finite state machine.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.util.fsm.State", OmitOptionalParameters = true, Export = false)]
    public partial class State : qx.core.Object
    {
		#region Properties

		/// <summary>
		/// <para>Automatic actions to take after return from the state&#8217;s onentry
		/// function.</para>
		/// <para>The value passed to setAutoActionsAfterOnentry() should like something
		/// akin to:</para>
		/// <code>
		/// "autoActionsAfterOnentry" :
		/// {
		/// // The name of a function.  This would become "setEnabled("
		/// "enabled" :
		/// [
		/// {
		/// // The parameter value, thus "setEnabled(true);"
		/// "parameters" : [ true ],
		/// // The function would be called on each object:
		/// //  this.getObject("obj1").setEnabled(true);
		/// //  this.getObject("obj2").setEnabled(true);
		/// "objects" : [ "obj1", "obj2" ]
		/// // And similarly for each object in each specified group.
		/// "groups"  : [ "group1", "group2" ],
		/// }
		/// ];
		/// };
		/// </code>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "autoActionsAfterOnentry", NativeField = true)]
		public object AutoActionsAfterOnentry { get; set; }

		/// <summary>
		/// <para>Automatic actions to take after returning from the state&#8217;s onexit
		/// function.</para>
		/// <para>The value passed to setAutoActionsAfterOnexit() should like something
		/// akin to:</para>
		/// <code>
		/// "autoActionsBeforeOnexit" :
		/// {
		/// // The name of a function.  This would become "setEnabled("
		/// "enabled" :
		/// [
		/// {
		/// // The parameter value, thus "setEnabled(true);"
		/// "parameters" : [ true ],
		/// // The function would be called on each object:
		/// //  this.getObject("obj1").setEnabled(true);
		/// //  this.getObject("obj2").setEnabled(true);
		/// "objects" : [ "obj1", "obj2" ]
		/// // And similarly for each object in each specified group.
		/// "groups"  : [ "group1", "group2" ],
		/// }
		/// ];
		/// };
		/// </code>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "autoActionsAfterOnexit", NativeField = true)]
		public object AutoActionsAfterOnexit { get; set; }

		/// <summary>
		/// <para>Automatic actions to take prior to calling the state&#8217;s onentry function.</para>
		/// <para>The value passed to setAutoActionsBeforeOnentry() should like something
		/// akin to:</para>
		/// <code>
		/// "autoActionsBeforeOnentry" :
		/// {
		/// // The name of a function.  This would become "setEnabled("
		/// "enabled" :
		/// [
		/// {
		/// // The parameter value, thus "setEnabled(true);"
		/// "parameters" : [ true ],
		/// // The function would be called on each object:
		/// //  this.getObject("obj1").setEnabled(true);
		/// //  this.getObject("obj2").setEnabled(true);
		/// "objects" : [ "obj1", "obj2" ]
		/// // And similarly for each object in each specified group.
		/// "groups"  : [ "group1", "group2" ],
		/// }
		/// ];
		/// };
		/// </code>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "autoActionsBeforeOnentry", NativeField = true)]
		public object AutoActionsBeforeOnentry { get; set; }

		/// <summary>
		/// <para>Automatic actions to take prior to calling the state&#8217;s onexit function.</para>
		/// <para>The value passed to setAutoActionsBeforeOnexit() should like something
		/// akin to:</para>
		/// <code>
		/// "autoActionsBeforeOnexit" :
		/// {
		/// // The name of a function.  This would become "setEnabled("
		/// "enabled" :
		/// [
		/// {
		/// // The parameter value, thus "setEnabled(true);"
		/// "parameters" : [ true ],
		/// // The function would be called on each object:
		/// //  this.getObject("obj1").setEnabled(true);
		/// //  this.getObject("obj2").setEnabled(true);
		/// "objects" : [ "obj1", "obj2" ]
		/// // And similarly for each object in each specified group.
		/// "groups"  : [ "group1", "group2" ],
		/// }
		/// ];
		/// };
		/// </code>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "autoActionsBeforeOnexit", NativeField = true)]
		public object AutoActionsBeforeOnexit { get; set; }

		/// <summary>
		/// <para>The object representing handled and blocked events for this state.
		/// This is documented in the constructor, and is typically provided
		/// through the constructor&#8217;s stateInfo object, but it is also possible
		/// (but highly NOT recommended) to change this dynamically.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "events", NativeField = true)]
		public object Events { get; set; }

		/// <summary>
		/// <para>The name of this state.  This name may be used as a Transition&#8217;s
		/// nextState value, or an explicit next state in the &#8216;events&#8217; handling
		/// list in a State.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "name", NativeField = true)]
		public object Name { get; set; }

		/// <summary>
		/// <para>The onentry function for this state.  This is documented in the
		/// constructor, and is typically provided through the constructor&#8217;s
		/// stateInfo object, but it is also possible (but highly NOT recommended)
		/// to change this dynamically.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "onentry", NativeField = true)]
		public object Onentry { get; set; }

		/// <summary>
		/// <para>The onexit function for this state.  This is documented in the
		/// constructor, and is typically provided through the constructor&#8217;s
		/// stateInfo object, but it is also possible (but highly NOT recommended)
		/// to change this dynamically.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "onexit", NativeField = true)]
		public object Onexit { get; set; }

		#endregion Properties

		#region Methods

		public State() { throw new NotImplementedException(); }

		/// <param name="stateName">The name of this state.  This is the name which may be referenced in objects of class qx.util.fsm.Transition, when passing of the transition&#8217;s predicate means transition to this state.</param>
		/// <param name="stateInfo"> An object containing any of the following properties:  context - A context in which all of the following functions should be run.  onentry - A function which is called upon entry to the state.  Its signature is function(fsm, event) and it is saved in the onentry property of the state object.  (This function is called after the Transition's action function and after the previous state's onexit function.)  In the onentry function:  fsm - The finite state machine object to which this state is attached.  event - The event that caused the finite state machine to run  onexit - A function which is called upon exit from the state.  Its signature is function(fsm, event) and it is saved in the onexit property of the state object.  (This function is called after the Transition's action function and before the next state's onentry function.)  In the onexit function:  fsm - The finite state machine object to which this state is attached.  event - The event that caused the finite state machine to run  autoActionsBeforeOnentry - autoActionsAfterOnentry - autoActionsBeforeOnexit - autoActionsAfterOnexit - Automatic actions which take place at the time specified by the property name.  In all cases, the action takes place immediately before or after the specified function.  The property value for each of these properties is an object which describes some number of functions to invoke on a set of specified objects (typically widgets).  An example, using autoActionsBeforeOnentry, might look like this:  "autoActionsBeforeOnentry" : { // The name of a function. "setEnabled" : [ { // The parameter value, thus "setEnabled(true);" "parameters" : [ true ],  // The function would be called on each object: //  this.getObject("obj1").setEnabled(true); //  this.getObject("obj2").setEnabled(true); "objects" : [ "obj1", "obj2" ],  // And similarly for each object in each specified group. "groups"  : [ "group1", "group2" ] } ],  // The name of another function. "setVisible" : [ { // The parameter value, thus "setVisible(false);" "parameters" : [ false ],  // The function would be called on each object and group, as // described above. "objects" : [ "obj3", "obj4" ], "groups"  : [ "group3", "group4" ] } ] };  events (required) - A description to the finite state machine of how to handle a particular event, optionally associated with a specific target object on which the event was dispatched.  This should be an object containing one property for each event which is either handled or blocked.  The property name should be the event name.  The property value should be one of:  (a) qx.util.fsm.FiniteStateMachine.EventHandling.PREDICATE  (b) qx.util.fsm.FiniteStateMachine.EventHandling.BLOCKED  (c) a string containing the name of an explicit Transition to use  (d) an object where each property name is the Friendly Name of an object (meaning that this rule applies if both the event and the event's target object's Friendly Name match), and its property value is one of (a), (b) or (c), above.  This object is saved in the events property of the state object.  Additional properties may be provided in stateInfo.  They will not be used by the finite state machine, but will be available via this.getUserData("") during the state's onentry and onexit functions. </param>
		public State(string stateName, object stateInfo) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a transition to a state</para>
		/// </summary>
		/// <param name="trans">An object of class qx.util.fsm.Transition representing a transition which is to be a part of this state.</param>
		[JsMethod(Name = "addTransition")]
		public void AddTransition(qx.util.fsm.Transition trans) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property autoActionsAfterOnentry.</para>
		/// </summary>
		[JsMethod(Name = "getAutoActionsAfterOnentry")]
		public object GetAutoActionsAfterOnentry() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property autoActionsAfterOnexit.</para>
		/// </summary>
		[JsMethod(Name = "getAutoActionsAfterOnexit")]
		public object GetAutoActionsAfterOnexit() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property autoActionsBeforeOnentry.</para>
		/// </summary>
		[JsMethod(Name = "getAutoActionsBeforeOnentry")]
		public object GetAutoActionsBeforeOnentry() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property autoActionsBeforeOnexit.</para>
		/// </summary>
		[JsMethod(Name = "getAutoActionsBeforeOnexit")]
		public object GetAutoActionsBeforeOnexit() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property events.</para>
		/// </summary>
		[JsMethod(Name = "getEvents")]
		public object GetEvents() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property name.</para>
		/// </summary>
		[JsMethod(Name = "getName")]
		public object GetName() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property onentry.</para>
		/// </summary>
		[JsMethod(Name = "getOnentry")]
		public object GetOnentry() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property onexit.</para>
		/// </summary>
		[JsMethod(Name = "getOnexit")]
		public object GetOnexit() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property autoActionsAfterOnentry
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property autoActionsAfterOnentry.</param>
		[JsMethod(Name = "initAutoActionsAfterOnentry")]
		public void InitAutoActionsAfterOnentry(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property autoActionsAfterOnexit
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property autoActionsAfterOnexit.</param>
		[JsMethod(Name = "initAutoActionsAfterOnexit")]
		public void InitAutoActionsAfterOnexit(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property autoActionsBeforeOnentry
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property autoActionsBeforeOnentry.</param>
		[JsMethod(Name = "initAutoActionsBeforeOnentry")]
		public void InitAutoActionsBeforeOnentry(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property autoActionsBeforeOnexit
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property autoActionsBeforeOnexit.</param>
		[JsMethod(Name = "initAutoActionsBeforeOnexit")]
		public void InitAutoActionsBeforeOnexit(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property events
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property events.</param>
		[JsMethod(Name = "initEvents")]
		public void InitEvents(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property name
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property name.</param>
		[JsMethod(Name = "initName")]
		public void InitName(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property onentry
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property onentry.</param>
		[JsMethod(Name = "initOnentry")]
		public void InitOnentry(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property onexit
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property onexit.</param>
		[JsMethod(Name = "initOnexit")]
		public void InitOnexit(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property autoActionsAfterOnentry.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAutoActionsAfterOnentry")]
		public void ResetAutoActionsAfterOnentry() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property autoActionsAfterOnexit.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAutoActionsAfterOnexit")]
		public void ResetAutoActionsAfterOnexit() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property autoActionsBeforeOnentry.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAutoActionsBeforeOnentry")]
		public void ResetAutoActionsBeforeOnentry() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property autoActionsBeforeOnexit.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAutoActionsBeforeOnexit")]
		public void ResetAutoActionsBeforeOnexit() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property events.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetEvents")]
		public void ResetEvents() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property name.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetName")]
		public void ResetName() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property onentry.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOnentry")]
		public void ResetOnentry() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property onexit.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOnexit")]
		public void ResetOnexit() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property autoActionsAfterOnentry.</para>
		/// </summary>
		/// <param name="value">New value for property autoActionsAfterOnentry.</param>
		[JsMethod(Name = "setAutoActionsAfterOnentry")]
		public void SetAutoActionsAfterOnentry(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property autoActionsAfterOnexit.</para>
		/// </summary>
		/// <param name="value">New value for property autoActionsAfterOnexit.</param>
		[JsMethod(Name = "setAutoActionsAfterOnexit")]
		public void SetAutoActionsAfterOnexit(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property autoActionsBeforeOnentry.</para>
		/// </summary>
		/// <param name="value">New value for property autoActionsBeforeOnentry.</param>
		[JsMethod(Name = "setAutoActionsBeforeOnentry")]
		public void SetAutoActionsBeforeOnentry(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property autoActionsBeforeOnexit.</para>
		/// </summary>
		/// <param name="value">New value for property autoActionsBeforeOnexit.</param>
		[JsMethod(Name = "setAutoActionsBeforeOnexit")]
		public void SetAutoActionsBeforeOnexit(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property events.</para>
		/// </summary>
		/// <param name="value">New value for property events.</param>
		[JsMethod(Name = "setEvents")]
		public void SetEvents(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property name.</para>
		/// </summary>
		/// <param name="value">New value for property name.</param>
		[JsMethod(Name = "setName")]
		public void SetName(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property onentry.</para>
		/// </summary>
		/// <param name="value">New value for property onentry.</param>
		[JsMethod(Name = "setOnentry")]
		public void SetOnentry(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property onexit.</para>
		/// </summary>
		/// <param name="value">New value for property onexit.</param>
		[JsMethod(Name = "setOnexit")]
		public void SetOnexit(object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}