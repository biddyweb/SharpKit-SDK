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
    /// <p>A specialized queue class that supports scheduling callbacks to execute
    /// sequentially, iteratively, even asynchronously.</p>
    /// <p>Callbacks can be function refs or objects with the following keys.  Only
    /// the <code>fn</code> key is required.</p>
    /// <ul>
    /// <li><code>fn</code> -- The callback function</li>
    /// <li><code>context</code> -- The execution context for the callbackFn.</li>
    /// <li><code>args</code> -- Arguments to pass to callbackFn.</li>
    /// <li><code>timeout</code> -- Millisecond delay before executing callbackFn.
    /// (Applies to each iterative execution of callback)</li>
    /// <li><code>iterations</code> -- Number of times to repeat the callback.
    /// <li><code>until</code> -- Repeat the callback until this function returns
    /// true.  This setting trumps iterations.</li>
    /// <li><code>autoContinue</code> -- Set to false to prevent the AsyncQueue from
    /// executing the next callback in the Queue after
    /// the callback completes.</li>
    /// <li><code>id</code> -- Name that can be used to get, promote, get the
    /// indexOf, or delete this callback.</li>
    /// </ul>
    /// </summary>
    public partial class AsyncQueue : Y_.EventTarget
    {
        /// <summary>
        /// Default functionality for the &quot;add&quot; event.  Adds the callbacks
        /// in the event facade to the queue. Callbacks successfully added to the
        /// queue are present in the event's <code>added</code> property in the
        /// after phase.
        /// </summary>
        protected void _defAddFn(Event e){}
        /// <summary>
        /// Default functionality for the &quot;execute&quot; event.  Executes the
        /// callback function
        /// </summary>
        protected void _defExecFn(Event e){}
        /// <summary>
        /// <p>Default functionality for the &quot;promote&quot; event.  Promotes the
        /// named callback to the head of the queue.</p>
        /// <p>The event object will contain a property &quot;callback&quot;, which
        /// holds the id of a callback or the callback object itself.</p>
        /// </summary>
        protected void _defPromoteFn(Event e){}
        /// <summary>
        /// <p>Default functionality for the &quot;remove&quot; event.  Removes the
        /// callback from the queue.</p>
        /// <p>The event object will contain a property &quot;callback&quot;, which
        /// holds the id of a callback or the callback object itself.</p>
        /// </summary>
        protected void _defRemoveFn(Event e){}
        /// <summary>
        /// Default functionality for the &quot;shift&quot; event.  Shifts the
        /// callback stored in the event object's <em>callback</em> property from
        /// the queue if it is the first item.
        /// </summary>
        protected void _defShiftFn(Event e){}
        /// <summary>
        /// Handles the execution of callbacks. Returns a boolean indicating
        /// whether it is appropriate to continue running.
        /// </summary>
        protected object _execute(object callback){return null;}
        /// <summary>
        /// Initializes the AsyncQueue instance properties and events.
        /// </summary>
        protected void _init(){}
        /// <summary>
        /// Initializes the instance events.
        /// </summary>
        protected void _initEvents(){}
        /// <summary>
        /// Creates a wrapper function to execute the callback using the aggregated
        /// configuration generated by combining the static AsyncQueue.defaults, the
        /// instance defaults, and the specified callback settings.
        /// The wrapper function is decorated with the callback configuration as
        /// properties for runtime modification.
        /// </summary>
        protected JsAction _prepare(object callback){return null;}
        /// <summary>
        /// Schedules the execution of asynchronous callbacks.
        /// </summary>
        protected object _schedule(object callback){return null;}
        /// <summary>
        /// Add any number of callbacks to the end of the queue. Callbacks may be
        /// provided as functions or objects.
        /// </summary>
        public AsyncQueue add(object callback){return null;}
        /// <summary>
        /// Retrieve a callback by its id.  Useful to modify the configuration
        /// while the queue is running.
        /// </summary>
        public object getCallback(object id){return null;}
        /// <summary>
        /// Returns the current index of a callback.  Pass in either the id or
        /// callback function from getCallback.
        /// </summary>
        public Y_.DataType_.Number indexOf(object callback){return null;}
        /// <summary>
        /// Determines if the queue is waiting for a callback to complete execution.
        /// </summary>
        public object isRunning(){return null;}
        /// <summary>
        /// Returns the next callback needing execution.  If a callback is
        /// configured to repeat via iterations or until, it will be returned until
        /// the completion criteria is met.
        /// When the queue is empty, null is returned.
        /// </summary>
        public JsAction next(){return null;}
        /// <summary>
        /// Pause the execution of the queue after the execution of the current
        /// callback completes.  If called from code outside of a queued callback,
        /// clears the timeout for the pending callback. Paused queue can be
        /// restarted with q.run()
        /// </summary>
        public AsyncQueue pause(){return null;}
        /// <summary>
        /// Promotes the named callback to the top of the queue. If a callback is
        /// currently executing or looping (via until or iterations), the promotion
        /// is scheduled to occur after the current callback has completed.
        /// </summary>
        public AsyncQueue promote(object callback){return null;}
        /// <summary>
        /// Removes the callback from the queue.  If the queue is active, the
        /// removal is scheduled to occur after the current callback has completed.
        /// </summary>
        public AsyncQueue remove(object callback){return null;}
        /// <summary>
        /// Sets the queue in motion.  All queued callbacks will be executed in
        /// order unless pause() or stop() is called or if one of the callbacks is
        /// configured with autoContinue: false.
        /// </summary>
        public AsyncQueue run(){return null;}
        /// <summary>
        /// Returns the number of callbacks in the queue.
        /// </summary>
        public Y_.DataType_.Number size(){return null;}
        /// <summary>
        /// Stop and clear the queue after the current execution of the
        /// current callback completes.
        /// </summary>
        public AsyncQueue stop(){return null;}
    }
}
