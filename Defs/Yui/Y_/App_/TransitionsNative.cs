//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.App_
{
    /// <summary>
    /// Provides the implementation of view transitions for `Y.App.Transitions` in
    /// browsers which support native CSS3 transitions.
    /// When this module is used, `Y.App.TransitionsNative` will automatically mix
    /// itself in to `Y.App`.
    /// </summary>
    public partial class TransitionsNative
    {
        /// <summary>
        /// Dequeues any pending calls to `_uiTransitionActiveView()`.
        /// **Note:** When there is more than one queued transition, only the most
        /// recent `activeView` change will be visually transitioned, while the others
        /// will have their `transition` option overridden to `false`.
        /// </summary>
        protected void _dequeueActiveView(){}
        /// <summary>
        /// Returns an object containing a named fx for both `viewIn` and `viewOut`
        /// based on the relationship between the specified `newView` and `oldView`.
        /// </summary>
        protected object _getFx(View newView, View oldView){return null;}
        /// <summary>
        /// Returns an object containing a named fx for both `viewIn` and `viewOut`
        /// based on the relationship between the specified `newView` and `oldView`.
        /// </summary>
        protected object _getFx(View newView, View oldView, object transition){return null;}
        /// <summary>
        /// Queues calls to `_uiTransitionActiveView()` to make sure a currently running
        /// transition isn't interrupted.
        /// **Note:** This method prevents the default `_uiSetActiveView()` method from
        /// running.
        /// </summary>
        protected void _queueActiveView(){}
        /// <summary>
        /// Performs the actual change of this app's `activeView` by visually
        /// transitioning between the `newView` and `oldView` using any specified
        /// `options`.
        /// The `newView` is attached to the app by rendering it to the `viewContainer`,
        /// and making this app a bubble target of its events.
        /// The `oldView` is detached from the app by removing it from the
        /// `viewContainer`, and removing this app as a bubble target for its events.
        /// The `oldView` will either be preserved or properly destroyed.
        /// **Note:** This method overrides `_uiSetActiveView()` and provides all of its
        /// functionality plus supports visual transitions. Also, the `activeView`
        /// attribute is read-only and can be changed by calling the `showView()`
        /// method.
        /// </summary>
        protected void _uiTransitionActiveView(View newView){}
        /// <summary>
        /// Performs the actual change of this app's `activeView` by visually
        /// transitioning between the `newView` and `oldView` using any specified
        /// `options`.
        /// The `newView` is attached to the app by rendering it to the `viewContainer`,
        /// and making this app a bubble target of its events.
        /// The `oldView` is detached from the app by removing it from the
        /// `viewContainer`, and removing this app as a bubble target for its events.
        /// The `oldView` will either be preserved or properly destroyed.
        /// **Note:** This method overrides `_uiSetActiveView()` and provides all of its
        /// functionality plus supports visual transitions. Also, the `activeView`
        /// attribute is read-only and can be changed by calling the `showView()`
        /// method.
        /// </summary>
        protected void _uiTransitionActiveView(View newView, object options){}
        /// <summary>
        /// Performs the actual change of this app's `activeView` by visually
        /// transitioning between the `newView` and `oldView` using any specified
        /// `options`.
        /// The `newView` is attached to the app by rendering it to the `viewContainer`,
        /// and making this app a bubble target of its events.
        /// The `oldView` is detached from the app by removing it from the
        /// `viewContainer`, and removing this app as a bubble target for its events.
        /// The `oldView` will either be preserved or properly destroyed.
        /// **Note:** This method overrides `_uiSetActiveView()` and provides all of its
        /// functionality plus supports visual transitions. Also, the `activeView`
        /// attribute is read-only and can be changed by calling the `showView()`
        /// method.
        /// </summary>
        protected void _uiTransitionActiveView(View newView, View oldView){}
        /// <summary>
        /// Performs the actual change of this app's `activeView` by visually
        /// transitioning between the `newView` and `oldView` using any specified
        /// `options`.
        /// The `newView` is attached to the app by rendering it to the `viewContainer`,
        /// and making this app a bubble target of its events.
        /// The `oldView` is detached from the app by removing it from the
        /// `viewContainer`, and removing this app as a bubble target for its events.
        /// The `oldView` will either be preserved or properly destroyed.
        /// **Note:** This method overrides `_uiSetActiveView()` and provides all of its
        /// functionality plus supports visual transitions. Also, the `activeView`
        /// attribute is read-only and can be changed by calling the `showView()`
        /// method.
        /// </summary>
        protected void _uiTransitionActiveView(View newView, View oldView, object options){}
        /// <summary>
        /// A queue that holds pending calls to this app's `_uiTransitionActiveView()`
        /// method.
        /// </summary>
        protected Y_.Array _viewTransitionQueue{get;set;}
    }
}
