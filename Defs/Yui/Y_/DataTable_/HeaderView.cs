//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.DataTable_
{
    /// <summary>
    /// View class responsible for rendering the `<thead>` section of a table. Used as
    /// the default `headerView` for `Y.DataTable.Base` and `Y.DataTable` classes.
    /// Translates the provided array of column configuration objects into a rendered
    /// `<thead>` based on the data in those objects.
    /// The structure of the column data is expected to be a single array of objects,
    /// where each object corresponds to a `<th>`.  Those objects may contain a
    /// `children` property containing a similarly structured array to indicate the
    /// nested cells should be grouped under the parent column's colspan in a separate
    /// row of header cells. E.g.
    /// <pre><code>
    /// new Y.DataTable.HeaderView({
    /// container: tableNode,
    /// columns: [
    /// { key: 'id' }, // no nesting
    /// { key: 'name', children: [
    /// { key: 'firstName', label: 'First' },
    /// { key: 'lastName',  label: 'Last' } ] }
    /// ]
    /// }).render();
    /// </code></pre>
    /// This would translate to the following visualization:
    /// <pre>
    /// ---------------------
    /// |    |     name     |
    /// |    |---------------
    /// | id | First | Last |
    /// ---------------------
    /// </pre>
    /// Supported properties of the column objects include:
    /// * `label`     - The HTML content of the header cell.
    /// * `key`       - If `label` is not specified, the `key` is used for content.
    /// * `children`  - Array of columns to appear below this column in the next
    /// row.
    /// * `headerTemplate` - Overrides the instance's `CELL_TEMPLATE` for cells in this
    /// column only.
    /// * `abbr`      - The content of the 'abbr' attribute of the `<th>`
    /// * `className` - Adds this string of CSS classes to the column header
    /// Through the life of instantiation and rendering, the column objects will have
    /// the following properties added to them:
    /// * `id`       - (Defaulted by DataTable) The id to assign the rendered column
    /// * `_colspan` - To supply the `<th>` attribute
    /// * `_rowspan` - To supply the `<th>` attribute
    /// * `_parent`  - (Added by DataTable) If the column is a child of another
    /// column, this points to its parent column
    /// The column object is also used to provide values for {placeholder} tokens in the
    /// instance's `CELL_TEMPLATE`, so you can modify the template and include other
    /// column object properties to populate them.
    /// </summary>
    public partial class HeaderView : View
    {
        /// <summary>
        /// Handles changes in the source's columns attribute.  Redraws the headers.
        /// </summary>
        protected void _afterColumnsChange(EventFacade e){}
        /// <summary>
        /// Translate the input column format into a structure useful for rendering a
        /// `<thead>`, rows, and cells.  The structure of the input is expected to be a
        /// single array of objects, where each object corresponds to a `<th>`.  Those
        /// objects may contain a `children` property containing a similarly structured
        /// array to indicate the nested cells should be grouped under the parent
        /// column's colspan in a separate row of header cells. E.g.
        /// <pre><code>
        /// [
        /// { key: 'id' }, // no nesting
        /// { key: 'name', children: [
        /// { key: 'firstName', label: 'First' },
        /// { key: 'lastName',  label: 'Last' } ] }
        /// ]
        /// </code></pre>
        /// would indicate two header rows with the first column 'id' being assigned a
        /// `rowspan` of `2`, the 'name' column appearing in the first row with a
        /// `colspan` of `2`, and the 'firstName' and 'lastName' columns appearing in
        /// the second row, below the 'name' column.
        /// <pre>
        /// ---------------------
        /// |    |     name     |
        /// |    |---------------
        /// | id | First | Last |
        /// ---------------------
        /// </pre>
        /// Supported properties of the column objects include:
        /// * `label`    - The HTML content of the header cell.
        /// * `key`      - If `label` is not specified, the `key` is used for content.
        /// * `children` - Array of columns to appear below this column in the next
        /// row.
        /// * `abbr`     - The content of the 'abbr' attribute of the `<th>`
        /// * `headerTemplate` - Overrides the instance's `CELL_TEMPLATE` for cells
        /// in this column only.
        /// The output structure is basically a simulation of the `<thead>` structure
        /// with arrays for rows and objects for cells.  Column objects have the
        /// following properties added to them:
        /// * `id`       - (Defaulted by DataTable) The id to assign the rendered
        /// column
        /// * `_colspan` - Per the `<th>` attribute
        /// * `_rowspan` - Per the `<th>` attribute
        /// * `_parent`  - (Added by DataTable) If the column is a child of another
        /// column, this points to its parent column
        /// The column object is also used to provide values for {placeholder}
        /// replacement in the `CELL_TEMPLATE`, so you can modify the template and
        /// include other column object properties to populate them.
        /// </summary>
        protected object _parseColumns(object data){return null;}
        /// <summary>
        /// Binds event subscriptions from the UI and the source (if assigned).
        /// </summary>
        protected void bindUI(){}
        /// <summary>
        /// Destroys the instance.
        /// </summary>
        protected void destructor(){}
        /// <summary>
        /// Builds a CSS class name from the provided tokens.  If the instance is
        /// created with `cssPrefix` or `source` in the configuration, it will use this
        /// prefix (the `_cssPrefix` of the `source` object) as the base token.  This
        /// allows class instances to generate markup with class names that correspond
        /// to the parent class that is consuming them.
        /// </summary>
        public object getClassName(object token){return null;}
        /// <summary>
        /// Initializes the instance. Reads the following configuration properties:
        /// * `columns` - (REQUIRED) The initial column information
        /// * `cssPrefix` - The base string for classes generated by `getClassName`
        /// * `source` - The object to serve as source of truth for column info
        /// </summary>
        protected void initializer(object config){}
        /// <summary>
        /// Creates the `<thead>` Node content by assembling markup generated by
        /// populating the `ROW_TEMPLATE` and `CELL_TEMPLATE` templates with content
        /// from the `columns` property.
        /// </summary>
        public HeaderView render(){return null;}
    }
}
