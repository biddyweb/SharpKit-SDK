/* Generated by SharpKit 5 v5.4.6 */
"use strict";
if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}


if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var System$Reflection$BindingFlags = {
    fullname: "System.Reflection.BindingFlags",
    staticDefinition: {
        CreateInstance: 512,
        DeclaredOnly: 2,
        Default: 0,
        ExactBinding: 65536,
        FlattenHierarchy: 64,
        GetField: 1024,
        GetProperty: 4096,
        IgnoreCase: 1,
        IgnoreReturn: 16777216,
        Instance: 4,
        InvokeMethod: 256,
        NonPublic: 32,
        OptionalParamBinding: 262144,
        Public: 16,
        PutDispProperty: 16384,
        PutRefDispProperty: 32768,
        SetField: 2048,
        SetProperty: 8192,
        Static: 8,
        SuppressChangeType: 131072
    },
    Kind: "Enum"
};
JsTypes.push(System$Reflection$BindingFlags);
var System$Reflection$MemberInfo = {
    fullname: "System.Reflection.MemberInfo",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            this._Name = null;
            this._DeclaringType = null;
            this._CustomAttributes = null;
            System.Object.ctor.call(this);
        },
        Name$$: "System.String",
        get_Name: function (){
            return this._Name;
        },
        DeclaringType$$: "SharpKit.JavaScript.Private.JsImplType",
        get_DeclaringType: function (){
            return this._DeclaringType;
        },
        VerifyCustomAttributes: function (){
            this.get_DeclaringType().VerifyCustomAttributesOnTypeAndMembers();
        },
        GetBaseMember: function (){
            return null;
        },
        AddCustomAttributes: function (list, attributeType, inherit){
            this.VerifyCustomAttributes();
            if (this._CustomAttributes != null){
                for (var i = 0; i < this._CustomAttributes.length; i++){
                    var att = this._CustomAttributes[i];
                    if (attributeType.IsInstanceOfType(att))
                        list.Add(att);
                }
            }
            if (inherit){
                var bm = this.GetBaseMember();
                if (bm != null)
                    bm.AddCustomAttributes(list, attributeType, inherit);
            }
        },
        GetCustomAttributes$$Type$$Boolean: function (attributeType, inherit){
            var list = new System.Collections.Generic.List$1.ctor(System.Object.ctor);
            this.AddCustomAttributes(list, attributeType, inherit);
            return list.ToArray();
        },
        GetCustomAttributes$$Boolean: function (inherit){
            if (inherit)
                throw $CreateException(new System.NotImplementedException.ctor$$String("GetCustomAttributes with inherit=true is not implemented"), new Error());
            this.VerifyCustomAttributes();
            return this._CustomAttributes;
        }
    }
};
JsTypes.push(System$Reflection$MemberInfo);
var System$Reflection$MethodBase = {
    fullname: "System.Reflection.MethodBase",
    baseTypeName: "System.Reflection.MemberInfo",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Reflection.MemberInfo.ctor.call(this);
        }
    }
};
JsTypes.push(System$Reflection$MethodBase);
var System$Reflection$MethodInfo = {
    fullname: "System.Reflection.MethodInfo",
    baseTypeName: "System.Reflection.MethodBase",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            this._IsStatic = false;
            this.JsFunction = null;
            this.JsName = null;
            System.Reflection.MethodBase.ctor.call(this);
        },
        IsStatic$$: "System.Boolean",
        get_IsStatic: function (){
            return this._IsStatic;
        },
        Invoke: function (obj, parameters){
            var func;
            if (this._IsStatic)
                func = this.JsFunction;
            else {
                if (obj == null)
                    throw $CreateException(new System.Exception.ctor$$String("Cannot invoke non static method without a target object"), new Error());
                func = obj[this.JsName];
            }
            var res;
            if (parameters == null)
                res = func.apply(obj);
            else
                res = func.apply(obj, parameters);
            return res;
        }
    }
};
JsTypes.push(System$Reflection$MethodInfo);
var System$Reflection$PropertyInfo = {
    fullname: "System.Reflection.PropertyInfo",
    baseTypeName: "System.Reflection.MemberInfo",
    staticDefinition: {
        op_Equality: function (left, right){
            return  left==right;
        },
        op_Inequality: function (left, right){
            return  left!=right;
        }
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            this._PropertyType = null;
            this._IsStatic = false;
            this._Getter = null;
            this._Setter = null;
            System.Reflection.MemberInfo.ctor.call(this);
        },
        GetBaseMember: function (){
            return null;
        },
        GetValue$$Object$$Object$Array: function (obj, indexes){
            if (this._Getter == null)
                throw $CreateException(new System.Exception.ctor$$String("Property " + this._Name + " doesn\'t have a getter"), new Error());
            var value = this._Getter.apply(obj, (indexes != null ? indexes :  []));
            return value;
        },
        GetValue$$Object: function (obj){
            return this.GetValue$$Object$$Object$Array(obj, null);
        },
        GetValue$$Object$$BindingFlags$$Binder$$Object$Array$$CultureInfo: function (obj, invokeAttr, binder, index, culture){
            return this.GetValue$$Object$$Object$Array(obj, index);
        },
        SetValue$$Object$$Object$$Object$Array: function (obj, value, indexes){
            if (this._Setter == null)
                throw $CreateException(new System.Exception.ctor$$String("Property " + this._Name + " doesn\'t have a setter"), new Error());
            if (indexes == null || indexes.length == 0){
                this._Setter.call(obj, value);
            }
            else {
                var arr = new Array(indexes);
                arr.push(value);
                this._Setter.apply(obj, (indexes != null ? indexes :  []));
            }
        },
        SetValue$$Object$$Object: function (obj, value){
            this.SetValue$$Object$$Object$$Object$Array(obj, value, null);
        },
        SetValue$$Object$$Object$$BindingFlags$$Binder$$Object$Array$$CultureInfo: function (obj, value, invokeAttr, binder, index, culture){
            this.SetValue$$Object$$Object$$Object$Array(obj, value, index);
        },
        Name$$: "System.String",
        get_Name: function (){
            return this._Name;
        },
        PropertyType$$: "SharpKit.JavaScript.Private.JsImplType",
        get_PropertyType: function (){
            return this._PropertyType;
        }
    }
};
JsTypes.push(System$Reflection$PropertyInfo);
var System$Type = {
    fullname: "System.Type",
    baseTypeName: "System.Reflection.MemberInfo",
    staticDefinition: {
        cctor: function (){
            System.Type.EmptyTypes = null;
        },
        _TypeOf: function (jsType){
            if (jsType == null)
                throw $CreateException(new System.Exception.ctor$$String("Cannot resovle type"), new Error());
            if (jsType._ClrType == null)
                jsType._ClrType = new System.Type.ctor(jsType);
            return jsType._ClrType;
        },
        GetType$$String: function (name){
            return System.Type.GetType$$String$$Boolean(name, false);
        },
        GetType$$String$$Boolean: function (name, throwOnError){
            if (JsTypeHelper._HasTypeArguments(name)){
                var jsTypeAndArgs = JsTypeHelper._GetTypeWithArguments(name, throwOnError);
                if (jsTypeAndArgs == null)
                    return null;
                var genericType = System.Type._TypeOf(jsTypeAndArgs[0]);
                var jsTypeArgs = jsTypeAndArgs[1];
                for (var i = 0; i < jsTypeArgs.length; i++){
                    jsTypeArgs[i] = System.Type._TypeOf(jsTypeArgs[i]);
                }
                var type = genericType._MakeGenericType(jsTypeArgs);
                return type;
            }
            var jsType = JsTypeHelper.GetType(name);
            if (jsType == null){
                if (throwOnError)
                    throw $CreateException(new System.Exception.ctor$$String("Type " + name + " was not found"), new Error());
                return null;
            }
            return System.Type._TypeOf(jsType);
        },
        GetType$$String$$Boolean$$Boolean: function (name, throwOnError, ignoreCase){
            if (ignoreCase)
                throw $CreateException(new System.NotImplementedException.ctor(), new Error());
            return System.Type.GetType$$String$$Boolean(name, throwOnError);
        }
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (jsType){
            this._JsType = null;
            this.allPropertiesVerified = false;
            this._PropertiesByName = null;
            this._Properties = null;
            this._MethodsByName = null;
            this._Methods = null;
            this.verifiedCustomAttributesOnTypeAndMembers = false;
            this._GenericTypeDefinition = null;
            this._TypeArguments = null;
            this._MakeGenericTypeCache = null;
            System.Reflection.MemberInfo.ctor.call(this);
            this._JsType = jsType;
            this._Name = this._JsType.name;
            if (System.Type.EmptyTypes == null)
                System.Type.EmptyTypes = new Array(0);
        },
        IsEnum$$: "System.Boolean",
        get_IsEnum: function (){
            return this._JsType.Kind == "Enum";
        },
        GetBaseMember: function (){
            return this.get_BaseType();
        },
        BaseType$$: "SharpKit.JavaScript.Private.JsImplType",
        get_BaseType: function (){
            if (this._JsType.baseType == null)
                return null;
            return System.Type._TypeOf(this._JsType.baseType);
        },
        FillProperties: function (def){
            for (var funcName in def){
                var isGetter = funcName.startsWith("get_");
                var isSetter = funcName.startsWith("set_");
                if (isGetter || isSetter)
                    this.FillProperty(def, funcName, isSetter);
            }
        },
        FillProperty: function (def, funcName, isSetter){
            var member = def[funcName];
            var func = member;
            var propName = funcName.substr(4);
            var prop = this._PropertiesByName[propName];
            if (System.Reflection.PropertyInfo.op_Equality(prop, null)){
                prop = new System.Reflection.PropertyInfo.ctor();
                this._PropertiesByName[propName] = prop;
                this._Properties.push(prop);
                prop._Name = propName;
                prop._DeclaringType = this;
                prop._IsStatic = this._JsType.staticDefinition != null && this._JsType.staticDefinition[funcName] != null;
                var propTypeName = JsTypeHelper.getMemberTypeName(def, propName);
                if (propTypeName != null)
                    prop._PropertyType = System.Type.GetType$$String(propTypeName);
                else {
                }
            }
            if (isSetter)
                prop._Setter = func;
            else
                prop._Getter = func;
        },
        TryFillProperty: function (def, name){
            if (def == null)
                return false;
            var getterName = "get_" + name;
            var setterName = "set_" + name;
            if (def.hasOwnProperty(getterName))
                this.FillProperty(def, getterName, false);
            if (def.hasOwnProperty(setterName))
                this.FillProperty(def, setterName, true);
            return this._PropertiesByName[name] != null;
        },
        GetProperty$$String: function (name){
            this.VerifyProperty(name);
            return this._PropertiesByName[name];
        },
        GetProperty$$String$$BindingFlags: function (name, bindingAttr){
            if (name == null)
                throw $CreateException(new System.ArgumentNullException.ctor$$String("name"), new Error());
            return this.GetProperty$$String(name);
        },
        GetProperty$$String$$Type: function (name, returnType){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        VerifyProperty: function (name){
            if (this._PropertiesByName == null){
                this._PropertiesByName = new Object();
                this._Properties = new Array();
            }
            if (this._PropertiesByName.hasOwnProperty(name))
                return;
            if (this.TryFillProperty(this._JsType.definition, name))
                return;
            if (this.TryFillProperty(this._JsType.staticDefinition, name))
                return;
            var baseType = this.get_BaseType();
            if (baseType != null){
                var pe = baseType.GetProperty$$String(name);
                if (System.Reflection.PropertyInfo.op_Inequality(pe, null)){
                    this._PropertiesByName[name] = pe;
                    this._Properties.push(pe);
                    return;
                }
            }
            this._PropertiesByName[name] = null;
        },
        VerifyProperties: function (){
            if (!this.allPropertiesVerified){
                this.allPropertiesVerified = true;
                if (this._PropertiesByName == null){
                    this._PropertiesByName = new Object();
                    this._Properties = new Array();
                }
                this.FillProperties(this._JsType.definition);
                this.FillProperties(this._JsType.staticDefinition);
                var baseType = this.get_BaseType();
                if (baseType != null){
                    var props = baseType.GetProperties();
                    for (var $i17 = 0,$l17 = props.length,pe = props[$i17]; $i17 < $l17; $i17++, pe = props[$i17]){
                        if (!this._PropertiesByName.hasOwnProperty(pe._Name)){
                            this._PropertiesByName[pe._Name] = pe;
                            this._Properties.push(pe);
                        }
                    }
                }
            }
        },
        GetProperties: function (){
            this.VerifyProperties();
            return this._Properties;
        },
        FillMethods: function (def){
            var isStatic = def == this._JsType.staticDefinition;
            for (var funcName in def){
                if (funcName == "toString")
                    continue;
                var func = def[funcName];
                if (SharpKit.JavaScript.Utils.Js.Typeof(func) != "function")
                    continue;
                var methodName = SharpKit.JavaScript.JsNamingHelper.JsFunctionNameToClrMethodName(funcName);
                var methods = this._MethodsByName[methodName];
                if (methods == null){
                    methods =  [];
                    this._MethodsByName[methodName] = methods;
                }
                var method = new System.Reflection.MethodInfo.ctor();
                methods.push(method);
                this._Methods.push(method);
                method._Name = methodName;
                method.JsName = funcName;
                method.JsFunction = func;
                method._DeclaringType = this;
                method._IsStatic = this._JsType.staticDefinition != null && this._JsType.staticDefinition[funcName] == func;
            }
        },
        GetMethod: function (name){
            this.VerifyMethods();
            var methods = this._MethodsByName[name];
            if (methods == null)
                return null;
            return methods[0];
        },
        VerifyMethods: function (){
            if (this._MethodsByName == null){
                this._MethodsByName = new Object();
                this._Methods = new Array();
                this.FillMethods(this._JsType.definition);
                this.FillMethods(this._JsType.staticDefinition);
                var baseType = this.get_BaseType();
                if (baseType != null){
                    var methods = baseType.GetMethods();
                    for (var $i18 = 0,$l18 = methods.length,me = methods[$i18]; $i18 < $l18; $i18++, me = methods[$i18]){
                        if (this._JsType.definition != null && this._JsType.definition.hasOwnProperty(me.JsName))
                            continue;
                        if (this._JsType.staticDefinition != null && this._JsType.staticDefinition.hasOwnProperty(me.JsName))
                            continue;
                        var list = this._MethodsByName[me._Name];
                        if (list == null){
                            list =  [];
                            this._MethodsByName[me._Name] = list;
                        }
                        list.push(me);
                        this._Methods.push(me);
                    }
                }
            }
        },
        GetMethods: function (){
            this.VerifyMethods();
            var arr =  [];
            for (var i = 0; i < this._Methods.length; i++){
                arr.push(this._Methods[i]);
            }
            return arr;
        },
        GetMethods$$String: function (name){
            this.VerifyMethods();
            return this._MethodsByName[name];
        },
        GetMethods$$BindingFlags: function (bindingFlags){
            return this.GetMethods();
        },
        VerifyCustomAttributes: function (){
            this.VerifyCustomAttributesOnTypeAndMembers();
        },
        Name$$: "System.String",
        get_Name: function (){
            return JsTypeHelper.GetName(this._JsType);
        },
        FullName$$: "System.String",
        get_FullName: function (){
            return this._JsType.fullname;
        },
        AssemblyQualifiedName$$: "System.String",
        get_AssemblyQualifiedName: function (){
            return JsTypeHelper.GetAssemblyQualifiedName(this._JsType);
        },
        VerifyCustomAttributesOnTypeAndMembers: function (){
            if (this.verifiedCustomAttributesOnTypeAndMembers)
                return;
            this.verifiedCustomAttributesOnTypeAndMembers = true;
            if (this._JsType.customAttributes == null)
                return;
            for (var i = 0; i < this._JsType.customAttributes.length; i++){
                var attDef = this._JsType.customAttributes[i];
                var attType = JsTypeHelper.GetType(attDef.typeName);
                var jsCtor = attType[attDef.ctorName];
                var att = SharpKit.JavaScript.Utils.Js.ApplyNew(jsCtor, attDef.positionalArguments);
                if (attDef.namedArguments != null){
                    for (var propName in attDef.namedArguments){
                        var value = attDef.namedArguments[propName];
                        if (SharpKit.JavaScript.Utils.Js.Typeof(value) == "function")
                            value = value.call(null);
                        att["set_" + propName].call(att, value);
                    }
                }
                var target = this.GetAttributeTarget(attDef.targetType, attDef.targetMemberName);
                if (target._CustomAttributes == null)
                    target._CustomAttributes = new Array();
                target._CustomAttributes.push(att);
            }
        },
        GetAttributeTarget: function (memberType, memberName){
            if (memberType == "type")
                return this;
            else if (memberType == "method"){
                var methodName = SharpKit.JavaScript.JsNamingHelper.JsFunctionNameToClrMethodName(memberName);
                var methods = this.GetMethods$$String(methodName);
                for (var $i19 = 0,$l19 = methods.length,method = methods[$i19]; $i19 < $l19; $i19++, method = methods[$i19]){
                    if (method.JsName == memberName)
                        return method;
                }
                return null;
            }
            else if (memberType == "property"){
                return this.GetProperty$$String(memberName);
            }
            else
                throw $CreateException(new System.NotImplementedException.ctor$$String("GetAttributeTarget not supported yet for memberType: " + memberType), new Error());
        },
        IsAssignableFrom: function (type){
            return TypeIs(type._JsType, this._JsType);
        },
        IsInstanceOfType: function (obj){
            return Is(obj, this._JsType);
        },
        toString: function (){
            return System.String.Format$$String$$Object$Array("{Name = " + this.get_Name() + " FullName = " + this.get_FullName() + "}", new Array(0));
        },
        MakeGenericType: function (typeArguments){
            
var x = []; 
for(var i=0;i<arguments.length;i++) 
	x.push(arguments[i]|| null);
return this._MakeGenericType(x);
        },
        GetGenericTypeDefinition: function (){
            return this._GenericTypeDefinition;
        },
        GetGenericArguments: function (){
            if (this._TypeArguments == null)
                return System.Type.EmptyTypes;
            return this._TypeArguments;
        },
        _MakeGenericType: function (typeArguments){
            if (this._MakeGenericTypeCache == null)
                this._MakeGenericTypeCache = new Object();
            var key = "";
            for (var i = 0; i < typeArguments.length; i++){
                var typeArg = typeArguments[i];
                key += typeArg._Name;
            }
            var t = this._MakeGenericTypeCache[key];
            if (t == null){
                t = new System.Type.ctor(this._JsType);
                this._MakeGenericTypeCache[key] = t;
                t._Name = this._Name;
                t._GenericTypeDefinition = this;
                t._TypeArguments = typeArguments;
                t._Properties = this._Properties;
                t._PropertiesByName = this._PropertiesByName;
                t._Methods = this._Methods;
                t._MethodsByName = this._MethodsByName;
                t._DeclaringType = this._DeclaringType;
                t._CustomAttributes = this._CustomAttributes;
            }
            return t;
        }
    }
};
JsTypes.push(System$Type);

