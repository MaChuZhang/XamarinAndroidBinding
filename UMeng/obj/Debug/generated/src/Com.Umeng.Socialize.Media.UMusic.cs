using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/UMusic", DoNotGenerateAcw=true)]
	public partial class UMusic : global::Com.Umeng.Socialize.Media.BaseMediaObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/UMusic", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMusic); }
		}

		protected UMusic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/constructor[@name='UMusic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe UMusic (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (UMusic)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/constructor[@name='UMusic' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe UMusic (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (UMusic)) {
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

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDuration);
			return cb_getDuration;
		}

		static int n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static Delegate cb_setDuration_I;
#pragma warning disable 0169
		static Delegate GetSetDuration_IHandler ()
		{
			if (cb_setDuration_I == null)
				cb_setDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDuration_I);
			return cb_setDuration_I;
		}

		static void n_SetDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_I;
		public virtual unsafe int Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()I", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDuration", "(I)V", "GetSetDuration_IHandler")]
			set {
				if (id_setDuration_I == IntPtr.Zero)
					id_setDuration_I = JNIEnv.GetMethodID (class_ref, "setDuration", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDuration_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getH5Url;
#pragma warning disable 0169
		static Delegate GetGetH5UrlHandler ()
		{
			if (cb_getH5Url == null)
				cb_getH5Url = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetH5Url);
			return cb_getH5Url;
		}

		static IntPtr n_GetH5Url (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.H5Url);
		}
#pragma warning restore 0169

		static Delegate cb_setH5Url_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetH5Url_Ljava_lang_String_Handler ()
		{
			if (cb_setH5Url_Ljava_lang_String_ == null)
				cb_setH5Url_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetH5Url_Ljava_lang_String_);
			return cb_setH5Url_Ljava_lang_String_;
		}

		static void n_SetH5Url_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.H5Url = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getH5Url;
		static IntPtr id_setH5Url_Ljava_lang_String_;
		public virtual unsafe string H5Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='getH5Url' and count(parameter)=0]"
			[Register ("getH5Url", "()Ljava/lang/String;", "GetGetH5UrlHandler")]
			get {
				if (id_getH5Url == IntPtr.Zero)
					id_getH5Url = JNIEnv.GetMethodID (class_ref, "getH5Url", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getH5Url), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getH5Url", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='setH5Url' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setH5Url", "(Ljava/lang/String;)V", "GetSetH5Url_Ljava_lang_String_Handler")]
			set {
				if (id_setH5Url_Ljava_lang_String_ == IntPtr.Zero)
					id_setH5Url_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setH5Url", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setH5Url_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setH5Url", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHighBandDataUrl;
#pragma warning disable 0169
		static Delegate GetGetHighBandDataUrlHandler ()
		{
			if (cb_getHighBandDataUrl == null)
				cb_getHighBandDataUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHighBandDataUrl);
			return cb_getHighBandDataUrl;
		}

		static IntPtr n_GetHighBandDataUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HighBandDataUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setHighBandDataUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHighBandDataUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setHighBandDataUrl_Ljava_lang_String_ == null)
				cb_setHighBandDataUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHighBandDataUrl_Ljava_lang_String_);
			return cb_setHighBandDataUrl_Ljava_lang_String_;
		}

		static void n_SetHighBandDataUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HighBandDataUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHighBandDataUrl;
		static IntPtr id_setHighBandDataUrl_Ljava_lang_String_;
		public virtual unsafe string HighBandDataUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='getHighBandDataUrl' and count(parameter)=0]"
			[Register ("getHighBandDataUrl", "()Ljava/lang/String;", "GetGetHighBandDataUrlHandler")]
			get {
				if (id_getHighBandDataUrl == IntPtr.Zero)
					id_getHighBandDataUrl = JNIEnv.GetMethodID (class_ref, "getHighBandDataUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHighBandDataUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHighBandDataUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='setHighBandDataUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHighBandDataUrl", "(Ljava/lang/String;)V", "GetSetHighBandDataUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setHighBandDataUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setHighBandDataUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHighBandDataUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHighBandDataUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHighBandDataUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLowBandDataUrl;
#pragma warning disable 0169
		static Delegate GetGetLowBandDataUrlHandler ()
		{
			if (cb_getLowBandDataUrl == null)
				cb_getLowBandDataUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLowBandDataUrl);
			return cb_getLowBandDataUrl;
		}

		static IntPtr n_GetLowBandDataUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LowBandDataUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setLowBandDataUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLowBandDataUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setLowBandDataUrl_Ljava_lang_String_ == null)
				cb_setLowBandDataUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLowBandDataUrl_Ljava_lang_String_);
			return cb_setLowBandDataUrl_Ljava_lang_String_;
		}

		static void n_SetLowBandDataUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LowBandDataUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLowBandDataUrl;
		static IntPtr id_setLowBandDataUrl_Ljava_lang_String_;
		public virtual unsafe string LowBandDataUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='getLowBandDataUrl' and count(parameter)=0]"
			[Register ("getLowBandDataUrl", "()Ljava/lang/String;", "GetGetLowBandDataUrlHandler")]
			get {
				if (id_getLowBandDataUrl == IntPtr.Zero)
					id_getLowBandDataUrl = JNIEnv.GetMethodID (class_ref, "getLowBandDataUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLowBandDataUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLowBandDataUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='setLowBandDataUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLowBandDataUrl", "(Ljava/lang/String;)V", "GetSetLowBandDataUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setLowBandDataUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setLowBandDataUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLowBandDataUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLowBandDataUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLowBandDataUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLowBandUrl;
#pragma warning disable 0169
		static Delegate GetGetLowBandUrlHandler ()
		{
			if (cb_getLowBandUrl == null)
				cb_getLowBandUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLowBandUrl);
			return cb_getLowBandUrl;
		}

		static IntPtr n_GetLowBandUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LowBandUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setLowBandUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLowBandUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setLowBandUrl_Ljava_lang_String_ == null)
				cb_setLowBandUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLowBandUrl_Ljava_lang_String_);
			return cb_setLowBandUrl_Ljava_lang_String_;
		}

		static void n_SetLowBandUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LowBandUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLowBandUrl;
		static IntPtr id_setLowBandUrl_Ljava_lang_String_;
		public virtual unsafe string LowBandUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='getLowBandUrl' and count(parameter)=0]"
			[Register ("getLowBandUrl", "()Ljava/lang/String;", "GetGetLowBandUrlHandler")]
			get {
				if (id_getLowBandUrl == IntPtr.Zero)
					id_getLowBandUrl = JNIEnv.GetMethodID (class_ref, "getLowBandUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLowBandUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLowBandUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='setLowBandUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLowBandUrl", "(Ljava/lang/String;)V", "GetSetLowBandUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setLowBandUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setLowBandUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLowBandUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLowBandUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLowBandUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMediaType;
#pragma warning disable 0169
		static Delegate GetGetMediaTypeHandler ()
		{
			if (cb_getMediaType == null)
				cb_getMediaType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaType);
			return cb_getMediaType;
		}

		static IntPtr n_GetMediaType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaType);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaType;
		public override unsafe global::Com.Umeng.Socialize.Media.UMediaObjectMediaType MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;", "GetGetMediaTypeHandler")]
			get {
				if (id_getMediaType == IntPtr.Zero)
					id_getMediaType = JNIEnv.GetMethodID (class_ref, "getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getmTargetUrl;
#pragma warning disable 0169
		static Delegate GetGetmTargetUrlHandler ()
		{
			if (cb_getmTargetUrl == null)
				cb_getmTargetUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetmTargetUrl);
			return cb_getmTargetUrl;
		}

		static IntPtr n_GetmTargetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetmTargetUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_getmTargetUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='getmTargetUrl' and count(parameter)=0]"
		[Register ("getmTargetUrl", "()Ljava/lang/String;", "GetGetmTargetUrlHandler")]
		public virtual unsafe string GetmTargetUrl ()
		{
			if (id_getmTargetUrl == IntPtr.Zero)
				id_getmTargetUrl = JNIEnv.GetMethodID (class_ref, "getmTargetUrl", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getmTargetUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmTargetUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setmTargetUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetmTargetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setmTargetUrl_Ljava_lang_String_ == null)
				cb_setmTargetUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetmTargetUrl_Ljava_lang_String_);
			return cb_setmTargetUrl_Ljava_lang_String_;
		}

		static void n_SetmTargetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetmTargetUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmTargetUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='setmTargetUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setmTargetUrl", "(Ljava/lang/String;)V", "GetSetmTargetUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetmTargetUrl (string p0)
		{
			if (id_setmTargetUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setmTargetUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setmTargetUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmTargetUrl_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmTargetUrl", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toByte;
#pragma warning disable 0169
		static Delegate GetToByteHandler ()
		{
			if (cb_toByte == null)
				cb_toByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByte);
			return cb_toByte;
		}

		static IntPtr n_ToByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.UMusic __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByte ());
		}
#pragma warning restore 0169

		static IntPtr id_toByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='toByte' and count(parameter)=0]"
		[Register ("toByte", "()[B", "GetToByteHandler")]
		public override unsafe byte[] ToByte ()
		{
			if (id_toByte == IntPtr.Zero)
				id_toByte = JNIEnv.GetMethodID (class_ref, "toByte", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toByte), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByte", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_toUrlExtraParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMusic']/method[@name='toUrlExtraParams' and count(parameter)=0]"
		[Register ("toUrlExtraParams", "()Ljava/util/Map;", "")]
		public override sealed unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToUrlExtraParams ()
		{
			if (id_toUrlExtraParams == IntPtr.Zero)
				id_toUrlExtraParams = JNIEnv.GetMethodID (class_ref, "toUrlExtraParams", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toUrlExtraParams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
