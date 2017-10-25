using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Sina.Weibo.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']"
	[global::Android.Runtime.Register ("com/sina/weibo/sdk/api/BaseMediaObject", DoNotGenerateAcw=true)]
	public abstract partial class BaseMediaObject : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='MEDIA_TYPE_CMD']"
		[Register ("MEDIA_TYPE_CMD")]
		public const int MediaTypeCmd = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='MEDIA_TYPE_IMAGE']"
		[Register ("MEDIA_TYPE_IMAGE")]
		public const int MediaTypeImage = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='MEDIA_TYPE_MUSIC']"
		[Register ("MEDIA_TYPE_MUSIC")]
		public const int MediaTypeMusic = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='MEDIA_TYPE_TEXT']"
		[Register ("MEDIA_TYPE_TEXT")]
		public const int MediaTypeText = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='MEDIA_TYPE_VIDEO']"
		[Register ("MEDIA_TYPE_VIDEO")]
		public const int MediaTypeVideo = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='MEDIA_TYPE_VOICE']"
		[Register ("MEDIA_TYPE_VOICE")]
		public const int MediaTypeVoice = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='MEDIA_TYPE_WEBPAGE']"
		[Register ("MEDIA_TYPE_WEBPAGE")]
		public const int MediaTypeWebpage = (int) 5;

		static IntPtr actionUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='actionUrl']"
		[Register ("actionUrl")]
		public string ActionUrl {
			get {
				if (actionUrl_jfieldId == IntPtr.Zero)
					actionUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "actionUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, actionUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (actionUrl_jfieldId == IntPtr.Zero)
					actionUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "actionUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, actionUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr description_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='description']"
		[Register ("description")]
		public string Description {
			get {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, description_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, description_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr identify_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='identify']"
		[Register ("identify")]
		public string Identify {
			get {
				if (identify_jfieldId == IntPtr.Zero)
					identify_jfieldId = JNIEnv.GetFieldID (class_ref, "identify", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, identify_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (identify_jfieldId == IntPtr.Zero)
					identify_jfieldId = JNIEnv.GetFieldID (class_ref, "identify", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, identify_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr schema_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='schema']"
		[Register ("schema")]
		public string Schema {
			get {
				if (schema_jfieldId == IntPtr.Zero)
					schema_jfieldId = JNIEnv.GetFieldID (class_ref, "schema", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, schema_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (schema_jfieldId == IntPtr.Zero)
					schema_jfieldId = JNIEnv.GetFieldID (class_ref, "schema", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, schema_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr thumbData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='thumbData']"
		[Register ("thumbData")]
		public IList<byte> ThumbData {
			get {
				if (thumbData_jfieldId == IntPtr.Zero)
					thumbData_jfieldId = JNIEnv.GetFieldID (class_ref, "thumbData", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, thumbData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (thumbData_jfieldId == IntPtr.Zero)
					thumbData_jfieldId = JNIEnv.GetFieldID (class_ref, "thumbData", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, thumbData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr title_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/field[@name='title']"
		[Register ("title")]
		public string Title {
			get {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, title_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, title_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/sina/weibo/sdk/api/BaseMediaObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseMediaObject); }
		}

		protected BaseMediaObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/constructor[@name='BaseMediaObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseMediaObject ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseMediaObject)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/constructor[@name='BaseMediaObject' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe BaseMediaObject (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseMediaObject)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_getObjType;
#pragma warning disable 0169
		static Delegate GetGetObjTypeHandler ()
		{
			if (cb_getObjType == null)
				cb_getObjType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetObjType);
			return cb_getObjType;
		}

		static int n_GetObjType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjType;
		}
#pragma warning restore 0169

		public abstract int ObjType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='getObjType' and count(parameter)=0]"
			[Register ("getObjType", "()I", "GetGetObjTypeHandler")] get;
		}

		static Delegate cb_checkArgs;
#pragma warning disable 0169
		static Delegate GetCheckArgsHandler ()
		{
			if (cb_checkArgs == null)
				cb_checkArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckArgs);
			return cb_checkArgs;
		}

		static bool n_CheckArgs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='checkArgs' and count(parameter)=0]"
		[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
		protected virtual unsafe bool CheckArgs ()
		{
			if (id_checkArgs == IntPtr.Zero)
				id_checkArgs = JNIEnv.GetMethodID (class_ref, "checkArgs", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkArgs);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkArgs", "()Z"));
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static IntPtr id_setThumbImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='setThumbImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setThumbImage", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe void SetThumbImage (global::Android.Graphics.Bitmap p0)
		{
			if (id_setThumbImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setThumbImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setThumbImage", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setThumbImage_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static Delegate cb_toExtraMediaObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToExtraMediaObject_Ljava_lang_String_Handler ()
		{
			if (cb_toExtraMediaObject_Ljava_lang_String_ == null)
				cb_toExtraMediaObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToExtraMediaObject_Ljava_lang_String_);
			return cb_toExtraMediaObject_Ljava_lang_String_;
		}

		static IntPtr n_ToExtraMediaObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToExtraMediaObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='toExtraMediaObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toExtraMediaObject", "(Ljava/lang/String;)Lcom/sina/weibo/sdk/api/BaseMediaObject;", "GetToExtraMediaObject_Ljava_lang_String_Handler")]
		protected abstract global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject ToExtraMediaObject (string p0);

		static Delegate cb_toExtraMediaString;
#pragma warning disable 0169
		static Delegate GetToExtraMediaStringHandler ()
		{
			if (cb_toExtraMediaString == null)
				cb_toExtraMediaString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToExtraMediaString);
			return cb_toExtraMediaString;
		}

		static IntPtr n_ToExtraMediaString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToExtraMediaString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='toExtraMediaString' and count(parameter)=0]"
		[Register ("toExtraMediaString", "()Ljava/lang/String;", "GetToExtraMediaStringHandler")]
		protected abstract string ToExtraMediaString ();

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/sina/weibo/sdk/api/BaseMediaObject", DoNotGenerateAcw=true)]
	internal partial class BaseMediaObjectInvoker : BaseMediaObject {

		public BaseMediaObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseMediaObjectInvoker); }
		}

		static IntPtr id_getObjType;
		public override unsafe int ObjType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='getObjType' and count(parameter)=0]"
			[Register ("getObjType", "()I", "GetGetObjTypeHandler")]
			get {
				if (id_getObjType == IntPtr.Zero)
					id_getObjType = JNIEnv.GetMethodID (class_ref, "getObjType", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getObjType);
				} finally {
				}
			}
		}

		static IntPtr id_toExtraMediaObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='toExtraMediaObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toExtraMediaObject", "(Ljava/lang/String;)Lcom/sina/weibo/sdk/api/BaseMediaObject;", "GetToExtraMediaObject_Ljava_lang_String_Handler")]
		protected override unsafe global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject ToExtraMediaObject (string p0)
		{
			if (id_toExtraMediaObject_Ljava_lang_String_ == IntPtr.Zero)
				id_toExtraMediaObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toExtraMediaObject", "(Ljava/lang/String;)Lcom/sina/weibo/sdk/api/BaseMediaObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject __ret = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toExtraMediaObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toExtraMediaString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='BaseMediaObject']/method[@name='toExtraMediaString' and count(parameter)=0]"
		[Register ("toExtraMediaString", "()Ljava/lang/String;", "GetToExtraMediaStringHandler")]
		protected override unsafe string ToExtraMediaString ()
		{
			if (id_toExtraMediaString == IntPtr.Zero)
				id_toExtraMediaString = JNIEnv.GetMethodID (class_ref, "toExtraMediaString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toExtraMediaString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
