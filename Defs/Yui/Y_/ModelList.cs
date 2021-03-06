//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// Provides an API for managing an ordered list of Model instances.
    /// In addition to providing convenient `add`, `create`, `reset`, and `remove`
    /// methods for managing the models in the list, ModelLists are also bubble targets
    /// for events on the model instances they contain. This means, for example, that
    /// you can add several models to a list, and then subscribe to the `*:change` event
    /// on the list to be notified whenever any model in the list changes.
    /// ModelLists also maintain sort order efficiently as models are added and removed,
    /// based on a custom `comparator` function you may define (if no comparator is
    /// defined, models are sorted in insertion order).
    /// </summary>
    public partial class ModelList : Y_.Base
    {
        /// <summary>
        /// Adds the specified _model_ if it isn't already in this list.
        /// If the model's `clientId` or `id` matches that of a model that's already in
        /// the list, an `error` event will be fired and the model will not be added.
        /// </summary>
        protected Model _add(object model){return null;}
        /// <summary>
        /// Adds the specified _model_ if it isn't already in this list.
        /// If the model's `clientId` or `id` matches that of a model that's already in
        /// the list, an `error` event will be fired and the model will not be added.
        /// </summary>
        protected Model _add(object model, object options){return null;}
        /// <summary>
        /// Updates the model maps when a model's `id` attribute changes.
        /// </summary>
        protected void _afterIdChange(EventFacade e){}
        /// <summary>
        /// Adds this list as a bubble target for the specified model's events.
        /// </summary>
        protected void _attachList(Model model){}
        /// <summary>
        /// Clears all internal state and the internal list of models, returning this
        /// list to an empty state. Automatically detaches all models in the list.
        /// </summary>
        protected void _clear(){}
        /// <summary>
        /// Compares the value _a_ to the value _b_ for sorting purposes. Values are
        /// assumed to be the result of calling a model's `comparator()` method. You can
        /// override this method to implement custom sorting logic, such as a descending
        /// sort or multi-field sorting.
        /// </summary>
        protected Y_.DataType_.Number _compare(object a, object b){return null;}
        /// <summary>
        /// Default event handler for `add` events.
        /// </summary>
        protected void _defAddFn(EventFacade e){}
        /// <summary>
        /// Default event handler for `remove` events.
        /// </summary>
        protected void _defRemoveFn(EventFacade e){}
        /// <summary>
        /// Default event handler for `reset` events.
        /// </summary>
        protected void _defResetFn(EventFacade e){}
        /// <summary>
        /// Removes this list as a bubble target for the specified model's events.
        /// </summary>
        protected void _detachList(Model model){}
        /// <summary>
        /// Returns the index at which the given _model_ should be inserted to maintain
        /// the sort order of the list.
        /// </summary>
        protected Y_.DataType_.Number _findIndex(Model model){return null;}
        /// <summary>
        /// Removes the specified _model_ if it's in this list.
        /// </summary>
        protected Model _remove(Model model){return null;}
        /// <summary>
        /// Removes the specified _model_ if it's in this list.
        /// </summary>
        protected Model _remove(Model model, object options){return null;}
        /// <summary>
        /// Array sort function used by `sort()` to re-sort the models in the list.
        /// </summary>
        protected Y_.DataType_.Number _sort(Model a, Model b){return null;}
        /// <summary>
        /// Adds the specified model or array of models to this list. You may also pass
        /// another ModelList instance, in which case all the models in that list will
        /// be added to this one as well.
        /// </summary>
        public Model add(object models){return null;}
        /// <summary>
        /// Adds the specified model or array of models to this list. You may also pass
        /// another ModelList instance, in which case all the models in that list will
        /// be added to this one as well.
        /// </summary>
        public Model add(object models, object options){return null;}
        /// <summary>
        /// Define this method to provide a function that takes a model as a parameter
        /// and returns a value by which that model should be sorted relative to other
        /// models in this list.
        /// By default, no comparator is defined, meaning that models will not be sorted
        /// (they'll be stored in the order they're added).
        /// </summary>
        public Y_.DataType_.Number comparator(Model model){return null;}
        /// <summary>
        /// Creates or updates the specified model on the server, then adds it to this
        /// list if the server indicates success.
        /// </summary>
        public Model create(object model){return null;}
        /// <summary>
        /// Creates or updates the specified model on the server, then adds it to this
        /// list if the server indicates success.
        /// </summary>
        public Model create(object model, JsAction callback){return null;}
        /// <summary>
        /// Creates or updates the specified model on the server, then adds it to this
        /// list if the server indicates success.
        /// </summary>
        public Model create(object model, object options){return null;}
        /// <summary>
        /// Creates or updates the specified model on the server, then adds it to this
        /// list if the server indicates success.
        /// </summary>
        public Model create(object model, object options, JsAction callback){return null;}
        /// <summary>
        /// Executes the supplied function on each model in this list. Returns an array
        /// containing the models for which the supplied function returned a truthy
        /// value.
        /// The callback function's `this` object will refer to this ModelList. Use
        /// `Y.bind()` to bind the `this` object to another object if desired.
        /// </summary>
        public Y_.Array filter(JsAction callback){return null;}
        /// <summary>
        /// Executes the supplied function on each model in this list. Returns an array
        /// containing the models for which the supplied function returned a truthy
        /// value.
        /// The callback function's `this` object will refer to this ModelList. Use
        /// `Y.bind()` to bind the `this` object to another object if desired.
        /// </summary>
        public Y_.Array filter(object options, JsAction callback){return null;}
        /// <summary>
        /// If _name_ refers to an attribute on this ModelList instance, returns the
        /// value of that attribute. Otherwise, returns an array containing the values
        /// of the specified attribute from each model in this list.
        /// </summary>
        public object get(object name){return null;}
        /// <summary>
        /// If _name_ refers to an attribute on this ModelList instance, returns the
        /// HTML-escaped value of that attribute. Otherwise, returns an array containing
        /// the HTML-escaped values of the specified attribute from each model in this
        /// list.
        /// The values are escaped using `Escape.html()`.
        /// </summary>
        public object getAsHTML(object name){return null;}
        /// <summary>
        /// If _name_ refers to an attribute on this ModelList instance, returns the
        /// URL-encoded value of that attribute. Otherwise, returns an array containing
        /// the URL-encoded values of the specified attribute from each model in this
        /// list.
        /// The values are encoded using the native `encodeURIComponent()` function.
        /// </summary>
        public object getAsURL(object name){return null;}
        /// <summary>
        /// Returns the model with the specified _clientId_, or `null` if not found.
        /// </summary>
        public Model getByClientId(object clientId){return null;}
        /// <summary>
        /// Returns the model with the specified _id_, or `null` if not found.
        /// Note that models aren't expected to have an id until they're saved, so if
        /// you're working with unsaved models, it may be safer to call
        /// `getByClientId()`.
        /// </summary>
        public Model getById(object id){return null;}
        /// <summary>
        /// Calls the named method on every model in the list. Any arguments provided
        /// after _name_ will be passed on to the invoked method.
        /// </summary>
        public Y_.Array invoke(object name){return null;}
        /// <summary>
        /// Calls the named method on every model in the list. Any arguments provided
        /// after _name_ will be passed on to the invoked method.
        /// </summary>
        public Y_.Array invoke(object name, object args_){return null;}
        /// <summary>
        /// Returns the model at the specified _index_.
        /// </summary>
        public Model item(Y_.DataType_.Number index){return null;}
        /// <summary>
        /// Loads this list of models from the server.
        /// This method delegates to the `sync()` method to perform the actual load
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// If the load operation succeeds, a `reset` event will be fired.
        /// </summary>
        public void load(){}
        /// <summary>
        /// Loads this list of models from the server.
        /// This method delegates to the `sync()` method to perform the actual load
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// If the load operation succeeds, a `reset` event will be fired.
        /// </summary>
        public void load(JsAction callback){}
        /// <summary>
        /// Loads this list of models from the server.
        /// This method delegates to the `sync()` method to perform the actual load
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// If the load operation succeeds, a `reset` event will be fired.
        /// </summary>
        public void load(object options){}
        /// <summary>
        /// Loads this list of models from the server.
        /// This method delegates to the `sync()` method to perform the actual load
        /// operation, which is an asynchronous action. Specify a _callback_ function to
        /// be notified of success or failure.
        /// If the load operation succeeds, a `reset` event will be fired.
        /// </summary>
        public void load(object options, JsAction callback){}
        /// <summary>
        /// Executes the specified function on each model in this list and returns an
        /// array of the function's collected return values.
        /// </summary>
        public Y_.Array map(JsAction fn){return null;}
        /// <summary>
        /// Executes the specified function on each model in this list and returns an
        /// array of the function's collected return values.
        /// </summary>
        public Y_.Array map(JsAction fn, object thisObj){return null;}
        /// <summary>
        /// Called to parse the _response_ when the list is loaded from the server.
        /// This method receives a server _response_ and is expected to return an array
        /// of model attribute hashes.
        /// The default implementation assumes that _response_ is either an array of
        /// attribute hashes or a JSON string that can be parsed into an array of
        /// attribute hashes. If _response_ is a JSON string and either `Y.JSON` or the
        /// native `JSON` object are available, it will be parsed automatically. If a
        /// parse error occurs, an `error` event will be fired and the model will not be
        /// updated.
        /// You may override this method to implement custom parsing logic if necessary.
        /// </summary>
        public object parse(object response){return null;}
        /// <summary>
        /// Removes the specified model or array of models from this list. You may also
        /// pass another ModelList instance to remove all the models that are in both
        /// that instance and this instance.
        /// </summary>
        public Model remove(object models){return null;}
        /// <summary>
        /// Removes the specified model or array of models from this list. You may also
        /// pass another ModelList instance to remove all the models that are in both
        /// that instance and this instance.
        /// </summary>
        public Model remove(object models, object options){return null;}
        /// <summary>
        /// Completely replaces all models in the list with those specified, and fires a
        /// single `reset` event.
        /// Use `reset` when you want to add or remove a large number of items at once
        /// with less overhead, and without firing `add` or `remove` events for each
        /// one.
        /// </summary>
        public void reset(){}
        /// <summary>
        /// Completely replaces all models in the list with those specified, and fires a
        /// single `reset` event.
        /// Use `reset` when you want to add or remove a large number of items at once
        /// with less overhead, and without firing `add` or `remove` events for each
        /// one.
        /// </summary>
        public void reset(object options){}
        /// <summary>
        /// Completely replaces all models in the list with those specified, and fires a
        /// single `reset` event.
        /// Use `reset` when you want to add or remove a large number of items at once
        /// with less overhead, and without firing `add` or `remove` events for each
        /// one.
        /// </summary>
        public void reset(object models, object options){}
        /// <summary>
        /// Forcibly re-sorts the list.
        /// Usually it shouldn't be necessary to call this method since the list
        /// maintains its sort order when items are added and removed, but if you change
        /// the `comparator` function after items are already in the list, you'll need
        /// to re-sort.
        /// </summary>
        public void sort(){}
        /// <summary>
        /// Forcibly re-sorts the list.
        /// Usually it shouldn't be necessary to call this method since the list
        /// maintains its sort order when items are added and removed, but if you change
        /// the `comparator` function after items are already in the list, you'll need
        /// to re-sort.
        /// </summary>
        public void sort(object options){}
        /// <summary>
        /// Override this method to provide a custom persistence implementation for this
        /// list. The default method just calls the callback without actually doing
        /// anything.
        /// This method is called internally by `load()`.
        /// </summary>
        public void sync(object action){}
        /// <summary>
        /// Override this method to provide a custom persistence implementation for this
        /// list. The default method just calls the callback without actually doing
        /// anything.
        /// This method is called internally by `load()`.
        /// </summary>
        public void sync(object action, JsAction callback){}
        /// <summary>
        /// Override this method to provide a custom persistence implementation for this
        /// list. The default method just calls the callback without actually doing
        /// anything.
        /// This method is called internally by `load()`.
        /// </summary>
        public void sync(object action, object options){}
        /// <summary>
        /// Override this method to provide a custom persistence implementation for this
        /// list. The default method just calls the callback without actually doing
        /// anything.
        /// This method is called internally by `load()`.
        /// </summary>
        public void sync(object action, object options, JsAction callback){}
        /// <summary>
        /// Returns an array containing the models in this list.
        /// </summary>
        public Y_.Array toArray(){return null;}
        /// <summary>
        /// Returns an array containing attribute hashes for each model in this list,
        /// suitable for being passed to `Y.JSON.stringify()`.
        /// Under the hood, this method calls `toJSON()` on each model in the list and
        /// pushes the results into an array.
        /// </summary>
        public object toJSON(){return null;}
    }
}
