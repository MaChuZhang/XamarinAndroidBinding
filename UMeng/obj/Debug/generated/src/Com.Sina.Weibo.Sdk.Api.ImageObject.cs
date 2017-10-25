using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Sina.Weibo.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']"
	[global::Android.Runtime.Register ("com/sina/weibo/sdk/api/ImageObject", DoNotGenerateAcw=true)]
	public partial class ImageObject : global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr imageData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/field[@name='imageData']"
		[Register ("imageData")]
		public IList<byte> ImageData {
			get {
				if (imageData_jfieldId == IntPtr.Zero)
					imageData_jfieldId = JNIEnv.GetFieldID (class_ref, "imageData", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, imageData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imageData_jfieldId == IntPtr.Zero)
					imageData_jfieldId = JNIEnv.GetFieldID (class_ref, "imageData", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, imageData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr imagePath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/field[@name='imagePath']"
		[Register ("imagePath")]
		public string ImagePath {
			get {
				if (imagePath_jfieldId == IntPtr.Zero)
					imagePath_jfieldId = JNIEnv.GetFieldID (class_ref, "imagePath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, imagePath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (imagePath_jfieldId == IntPtr.Zero)
					imagePath_jfieldId = JNIEnv.GetFieldID (class_ref, "imagePath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, imagePath_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/sina/weibo/sdk/api/ImageObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageObject); }
		}

		protected ImageObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/constructor[@name='ImageObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageObject ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageObject)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/constructor[@name='ImageObject' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe ImageObject (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageObject)) {
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
			global::Com.Sina.Weibo.Sdk.Api.ImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.ImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjType;
		}
#pragma warning restore 0169

		static IntPtr id_getObjType;
		public override unsafe int ObjType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/method[@name='getObjType' and count(parameter)=0]"
			[Register ("getObjType", "()I", "GetGetObjTypeHandler")]
			get {
				if (id_getObjType == IntPtr.Zero)
					id_getObjType = JNIEnv.GetMethodID (class_ref, "getObjType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getObjType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjType", "()I"));
				} finally {
				}
			}
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
			global::Com.Sina.Weibo.Sdk.Api.ImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.ImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckArgs ();
		}
#pragma warning restore 0169

		static IntPtr id_checkArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/method[@name='checkArgs' and count(parameter)=0]"
		[Register ("checkArgs", "()Z", "GetCheckArgsHandler")]
		public virtual unsafe bool CheckArgs ()
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

		static IntPtr id_setImageObject_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/method[@name='setImageObject' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImageObject", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe void SetImageObject (global::Android.Graphics.Bitmap p0)
		{
			if (id_setImageObject_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setImageObject_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setImageObject", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageObject_Landroid_graphics_Bitmap_, __args);
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
			global::Com.Sina.Weibo.Sdk.Api.ImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.ImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToExtraMediaObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toExtraMediaObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/method[@name='toExtraMediaObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toExtraMediaObject", "(Ljava/lang/String;)Lcom/sina/weibo/sdk/api/BaseMediaObject;", "GetToExtraMediaObject_Ljava_lang_String_Handler")]
		protected override unsafe global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject ToExtraMediaObject (string p0)
		{
			if (id_toExtraMediaObject_Ljava_lang_String_ == IntPtr.Zero)
				id_toExtraMediaObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toExtraMediaObject", "(Ljava/lang/String;)Lcom/sina/weibo/sdk/api/BaseMediaObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toExtraMediaObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.BaseMediaObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toExtraMediaObject", "(Ljava/lang/String;)Lcom/sina/weibo/sdk/api/BaseMediaObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

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
			global::Com.Sina.Weibo.Sdk.Api.ImageObject __this = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.ImageObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToExtraMediaString ());
		}
#pragma warning restore 0169

		static IntPtr id_toExtraMediaString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sina.weibo.sdk.api']/class[@name='ImageObject']/method[@name='toExtraMediaString' and count(parameter)=0]"
		[Register ("toExtraMediaString", "()Ljava/lang/String;", "GetToExtraMediaStringHandler")]
		protected override unsafe string ToExtraMediaString ()
		{
			if (id_toExtraMediaString == IntPtr.Zero)
				id_toExtraMediaString = JNIEnv.GetMethodID (class_ref, "toExtraMediaString", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toExtraMediaString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toExtraMediaString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
