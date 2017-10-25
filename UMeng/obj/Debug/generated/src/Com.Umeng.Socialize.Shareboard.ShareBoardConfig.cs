using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Shareboard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']"
	[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/ShareBoardConfig", DoNotGenerateAcw=true)]
	public partial class ShareBoardConfig : global::Java.Lang.Object {


		static IntPtr BG_SHAPE_CIRCULAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/field[@name='BG_SHAPE_CIRCULAR']"
		[Register ("BG_SHAPE_CIRCULAR")]
		public static int BgShapeCircular {
			get {
				if (BG_SHAPE_CIRCULAR_jfieldId == IntPtr.Zero)
					BG_SHAPE_CIRCULAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BG_SHAPE_CIRCULAR", "I");
				return JNIEnv.GetStaticIntField (class_ref, BG_SHAPE_CIRCULAR_jfieldId);
			}
			set {
				if (BG_SHAPE_CIRCULAR_jfieldId == IntPtr.Zero)
					BG_SHAPE_CIRCULAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BG_SHAPE_CIRCULAR", "I");
				try {
					JNIEnv.SetStaticField (class_ref, BG_SHAPE_CIRCULAR_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr BG_SHAPE_NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/field[@name='BG_SHAPE_NONE']"
		[Register ("BG_SHAPE_NONE")]
		public static int BgShapeNone {
			get {
				if (BG_SHAPE_NONE_jfieldId == IntPtr.Zero)
					BG_SHAPE_NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BG_SHAPE_NONE", "I");
				return JNIEnv.GetStaticIntField (class_ref, BG_SHAPE_NONE_jfieldId);
			}
			set {
				if (BG_SHAPE_NONE_jfieldId == IntPtr.Zero)
					BG_SHAPE_NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BG_SHAPE_NONE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, BG_SHAPE_NONE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr BG_SHAPE_ROUNDED_SQUARE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/field[@name='BG_SHAPE_ROUNDED_SQUARE']"
		[Register ("BG_SHAPE_ROUNDED_SQUARE")]
		public static int BgShapeRoundedSquare {
			get {
				if (BG_SHAPE_ROUNDED_SQUARE_jfieldId == IntPtr.Zero)
					BG_SHAPE_ROUNDED_SQUARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BG_SHAPE_ROUNDED_SQUARE", "I");
				return JNIEnv.GetStaticIntField (class_ref, BG_SHAPE_ROUNDED_SQUARE_jfieldId);
			}
			set {
				if (BG_SHAPE_ROUNDED_SQUARE_jfieldId == IntPtr.Zero)
					BG_SHAPE_ROUNDED_SQUARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BG_SHAPE_ROUNDED_SQUARE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, BG_SHAPE_ROUNDED_SQUARE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr SHAREBOARD_POSITION_BOTTOM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/field[@name='SHAREBOARD_POSITION_BOTTOM']"
		[Register ("SHAREBOARD_POSITION_BOTTOM")]
		public static int ShareboardPositionBottom {
			get {
				if (SHAREBOARD_POSITION_BOTTOM_jfieldId == IntPtr.Zero)
					SHAREBOARD_POSITION_BOTTOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHAREBOARD_POSITION_BOTTOM", "I");
				return JNIEnv.GetStaticIntField (class_ref, SHAREBOARD_POSITION_BOTTOM_jfieldId);
			}
			set {
				if (SHAREBOARD_POSITION_BOTTOM_jfieldId == IntPtr.Zero)
					SHAREBOARD_POSITION_BOTTOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHAREBOARD_POSITION_BOTTOM", "I");
				try {
					JNIEnv.SetStaticField (class_ref, SHAREBOARD_POSITION_BOTTOM_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr SHAREBOARD_POSITION_CENTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/field[@name='SHAREBOARD_POSITION_CENTER']"
		[Register ("SHAREBOARD_POSITION_CENTER")]
		public static int ShareboardPositionCenter {
			get {
				if (SHAREBOARD_POSITION_CENTER_jfieldId == IntPtr.Zero)
					SHAREBOARD_POSITION_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHAREBOARD_POSITION_CENTER", "I");
				return JNIEnv.GetStaticIntField (class_ref, SHAREBOARD_POSITION_CENTER_jfieldId);
			}
			set {
				if (SHAREBOARD_POSITION_CENTER_jfieldId == IntPtr.Zero)
					SHAREBOARD_POSITION_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHAREBOARD_POSITION_CENTER", "I");
				try {
					JNIEnv.SetStaticField (class_ref, SHAREBOARD_POSITION_CENTER_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/shareboard/ShareBoardConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareBoardConfig); }
		}

		protected ShareBoardConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/constructor[@name='ShareBoardConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShareBoardConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ShareBoardConfig)) {
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

		static Delegate cb_setCancelButtonBackground_I;
#pragma warning disable 0169
		static Delegate GetSetCancelButtonBackground_IHandler ()
		{
			if (cb_setCancelButtonBackground_I == null)
				cb_setCancelButtonBackground_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetCancelButtonBackground_I);
			return cb_setCancelButtonBackground_I;
		}

		static IntPtr n_SetCancelButtonBackground_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCancelButtonBackground (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setCancelButtonBackground_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setCancelButtonBackground' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCancelButtonBackground", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetCancelButtonBackground_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetCancelButtonBackground (int p0)
		{
			if (id_setCancelButtonBackground_I == IntPtr.Zero)
				id_setCancelButtonBackground_I = JNIEnv.GetMethodID (class_ref, "setCancelButtonBackground", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCancelButtonBackground_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCancelButtonBackground", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCancelButtonBackground_II;
#pragma warning disable 0169
		static Delegate GetSetCancelButtonBackground_IIHandler ()
		{
			if (cb_setCancelButtonBackground_II == null)
				cb_setCancelButtonBackground_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_SetCancelButtonBackground_II);
			return cb_setCancelButtonBackground_II;
		}

		static IntPtr n_SetCancelButtonBackground_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCancelButtonBackground (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_setCancelButtonBackground_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setCancelButtonBackground' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCancelButtonBackground", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetCancelButtonBackground_IIHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetCancelButtonBackground (int p0, int p1)
		{
			if (id_setCancelButtonBackground_II == IntPtr.Zero)
				id_setCancelButtonBackground_II = JNIEnv.GetMethodID (class_ref, "setCancelButtonBackground", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCancelButtonBackground_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCancelButtonBackground", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCancelButtonText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCancelButtonText_Ljava_lang_String_Handler ()
		{
			if (cb_setCancelButtonText_Ljava_lang_String_ == null)
				cb_setCancelButtonText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCancelButtonText_Ljava_lang_String_);
			return cb_setCancelButtonText_Ljava_lang_String_;
		}

		static IntPtr n_SetCancelButtonText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCancelButtonText (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCancelButtonText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setCancelButtonText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCancelButtonText", "(Ljava/lang/String;)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetCancelButtonText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetCancelButtonText (string p0)
		{
			if (id_setCancelButtonText_Ljava_lang_String_ == IntPtr.Zero)
				id_setCancelButtonText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCancelButtonText", "(Ljava/lang/String;)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCancelButtonText_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCancelButtonText", "(Ljava/lang/String;)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCancelButtonTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetCancelButtonTextColor_IHandler ()
		{
			if (cb_setCancelButtonTextColor_I == null)
				cb_setCancelButtonTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetCancelButtonTextColor_I);
			return cb_setCancelButtonTextColor_I;
		}

		static IntPtr n_SetCancelButtonTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCancelButtonTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setCancelButtonTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setCancelButtonTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCancelButtonTextColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetCancelButtonTextColor_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetCancelButtonTextColor (int p0)
		{
			if (id_setCancelButtonTextColor_I == IntPtr.Zero)
				id_setCancelButtonTextColor_I = JNIEnv.GetMethodID (class_ref, "setCancelButtonTextColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCancelButtonTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCancelButtonTextColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCancelButtonVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetCancelButtonVisibility_ZHandler ()
		{
			if (cb_setCancelButtonVisibility_Z == null)
				cb_setCancelButtonVisibility_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetCancelButtonVisibility_Z);
			return cb_setCancelButtonVisibility_Z;
		}

		static IntPtr n_SetCancelButtonVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCancelButtonVisibility (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setCancelButtonVisibility_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setCancelButtonVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCancelButtonVisibility", "(Z)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetCancelButtonVisibility_ZHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetCancelButtonVisibility (bool p0)
		{
			if (id_setCancelButtonVisibility_Z == IntPtr.Zero)
				id_setCancelButtonVisibility_Z = JNIEnv.GetMethodID (class_ref, "setCancelButtonVisibility", "(Z)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCancelButtonVisibility_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCancelButtonVisibility", "(Z)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIndicatorColor_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorColor_IHandler ()
		{
			if (cb_setIndicatorColor_I == null)
				cb_setIndicatorColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetIndicatorColor_I);
			return cb_setIndicatorColor_I;
		}

		static IntPtr n_SetIndicatorColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIndicatorColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setIndicatorColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setIndicatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIndicatorColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetIndicatorColor_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetIndicatorColor (int p0)
		{
			if (id_setIndicatorColor_I == IntPtr.Zero)
				id_setIndicatorColor_I = JNIEnv.GetMethodID (class_ref, "setIndicatorColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIndicatorColor_II;
#pragma warning disable 0169
		static Delegate GetSetIndicatorColor_IIHandler ()
		{
			if (cb_setIndicatorColor_II == null)
				cb_setIndicatorColor_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_SetIndicatorColor_II);
			return cb_setIndicatorColor_II;
		}

		static IntPtr n_SetIndicatorColor_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIndicatorColor (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_setIndicatorColor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setIndicatorColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setIndicatorColor", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetIndicatorColor_IIHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetIndicatorColor (int p0, int p1)
		{
			if (id_setIndicatorColor_II == IntPtr.Zero)
				id_setIndicatorColor_II = JNIEnv.GetMethodID (class_ref, "setIndicatorColor", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorColor_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorColor", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIndicatorVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetIndicatorVisibility_ZHandler ()
		{
			if (cb_setIndicatorVisibility_Z == null)
				cb_setIndicatorVisibility_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetIndicatorVisibility_Z);
			return cb_setIndicatorVisibility_Z;
		}

		static IntPtr n_SetIndicatorVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIndicatorVisibility (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setIndicatorVisibility_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setIndicatorVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndicatorVisibility", "(Z)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetIndicatorVisibility_ZHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetIndicatorVisibility (bool p0)
		{
			if (id_setIndicatorVisibility_Z == IntPtr.Zero)
				id_setIndicatorVisibility_Z = JNIEnv.GetMethodID (class_ref, "setIndicatorVisibility", "(Z)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorVisibility_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorVisibility", "(Z)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMenuItemBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetMenuItemBackgroundColor_IHandler ()
		{
			if (cb_setMenuItemBackgroundColor_I == null)
				cb_setMenuItemBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMenuItemBackgroundColor_I);
			return cb_setMenuItemBackgroundColor_I;
		}

		static IntPtr n_SetMenuItemBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMenuItemBackgroundColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMenuItemBackgroundColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setMenuItemBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMenuItemBackgroundColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetMenuItemBackgroundColor_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetMenuItemBackgroundColor (int p0)
		{
			if (id_setMenuItemBackgroundColor_I == IntPtr.Zero)
				id_setMenuItemBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setMenuItemBackgroundColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMenuItemBackgroundColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMenuItemBackgroundColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMenuItemBackgroundColor_II;
#pragma warning disable 0169
		static Delegate GetSetMenuItemBackgroundColor_IIHandler ()
		{
			if (cb_setMenuItemBackgroundColor_II == null)
				cb_setMenuItemBackgroundColor_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_SetMenuItemBackgroundColor_II);
			return cb_setMenuItemBackgroundColor_II;
		}

		static IntPtr n_SetMenuItemBackgroundColor_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMenuItemBackgroundColor (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_setMenuItemBackgroundColor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setMenuItemBackgroundColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setMenuItemBackgroundColor", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetMenuItemBackgroundColor_IIHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetMenuItemBackgroundColor (int p0, int p1)
		{
			if (id_setMenuItemBackgroundColor_II == IntPtr.Zero)
				id_setMenuItemBackgroundColor_II = JNIEnv.GetMethodID (class_ref, "setMenuItemBackgroundColor", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMenuItemBackgroundColor_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMenuItemBackgroundColor", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMenuItemBackgroundShape_I;
#pragma warning disable 0169
		static Delegate GetSetMenuItemBackgroundShape_IHandler ()
		{
			if (cb_setMenuItemBackgroundShape_I == null)
				cb_setMenuItemBackgroundShape_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMenuItemBackgroundShape_I);
			return cb_setMenuItemBackgroundShape_I;
		}

		static IntPtr n_SetMenuItemBackgroundShape_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMenuItemBackgroundShape (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMenuItemBackgroundShape_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setMenuItemBackgroundShape' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMenuItemBackgroundShape", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetMenuItemBackgroundShape_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetMenuItemBackgroundShape (int p0)
		{
			if (id_setMenuItemBackgroundShape_I == IntPtr.Zero)
				id_setMenuItemBackgroundShape_I = JNIEnv.GetMethodID (class_ref, "setMenuItemBackgroundShape", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMenuItemBackgroundShape_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMenuItemBackgroundShape", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMenuItemBackgroundShape_II;
#pragma warning disable 0169
		static Delegate GetSetMenuItemBackgroundShape_IIHandler ()
		{
			if (cb_setMenuItemBackgroundShape_II == null)
				cb_setMenuItemBackgroundShape_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_SetMenuItemBackgroundShape_II);
			return cb_setMenuItemBackgroundShape_II;
		}

		static IntPtr n_SetMenuItemBackgroundShape_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMenuItemBackgroundShape (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_setMenuItemBackgroundShape_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setMenuItemBackgroundShape' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setMenuItemBackgroundShape", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetMenuItemBackgroundShape_IIHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetMenuItemBackgroundShape (int p0, int p1)
		{
			if (id_setMenuItemBackgroundShape_II == IntPtr.Zero)
				id_setMenuItemBackgroundShape_II = JNIEnv.GetMethodID (class_ref, "setMenuItemBackgroundShape", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMenuItemBackgroundShape_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMenuItemBackgroundShape", "(II)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMenuItemIconPressedColor_I;
#pragma warning disable 0169
		static Delegate GetSetMenuItemIconPressedColor_IHandler ()
		{
			if (cb_setMenuItemIconPressedColor_I == null)
				cb_setMenuItemIconPressedColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMenuItemIconPressedColor_I);
			return cb_setMenuItemIconPressedColor_I;
		}

		static IntPtr n_SetMenuItemIconPressedColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMenuItemIconPressedColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMenuItemIconPressedColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setMenuItemIconPressedColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMenuItemIconPressedColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetMenuItemIconPressedColor_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetMenuItemIconPressedColor (int p0)
		{
			if (id_setMenuItemIconPressedColor_I == IntPtr.Zero)
				id_setMenuItemIconPressedColor_I = JNIEnv.GetMethodID (class_ref, "setMenuItemIconPressedColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMenuItemIconPressedColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMenuItemIconPressedColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMenuItemTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetMenuItemTextColor_IHandler ()
		{
			if (cb_setMenuItemTextColor_I == null)
				cb_setMenuItemTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMenuItemTextColor_I);
			return cb_setMenuItemTextColor_I;
		}

		static IntPtr n_SetMenuItemTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMenuItemTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMenuItemTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setMenuItemTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMenuItemTextColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetMenuItemTextColor_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetMenuItemTextColor (int p0)
		{
			if (id_setMenuItemTextColor_I == IntPtr.Zero)
				id_setMenuItemTextColor_I = JNIEnv.GetMethodID (class_ref, "setMenuItemTextColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMenuItemTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMenuItemTextColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_Handler ()
		{
			if (cb_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ == null)
				cb_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_);
			return cb_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_;
		}

		static IntPtr n_SetOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.PopupWindow.IOnDismissListener p0 = (global::Android.Widget.PopupWindow.IOnDismissListener)global::Java.Lang.Object.GetObject<global::Android.Widget.PopupWindow.IOnDismissListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnDismissListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setOnDismissListener' and count(parameter)=1 and parameter[1][@type='android.widget.PopupWindow.OnDismissListener']]"
		[Register ("setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetOnDismissListener (global::Android.Widget.PopupWindow.IOnDismissListener p0)
		{
			if (id_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ == IntPtr.Zero)
				id_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ = JNIEnv.GetMethodID (class_ref, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setShareboardBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetShareboardBackgroundColor_IHandler ()
		{
			if (cb_setShareboardBackgroundColor_I == null)
				cb_setShareboardBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetShareboardBackgroundColor_I);
			return cb_setShareboardBackgroundColor_I;
		}

		static IntPtr n_SetShareboardBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShareboardBackgroundColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setShareboardBackgroundColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setShareboardBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShareboardBackgroundColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetShareboardBackgroundColor_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetShareboardBackgroundColor (int p0)
		{
			if (id_setShareboardBackgroundColor_I == IntPtr.Zero)
				id_setShareboardBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setShareboardBackgroundColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShareboardBackgroundColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShareboardBackgroundColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setShareboardPostion_I;
#pragma warning disable 0169
		static Delegate GetSetShareboardPostion_IHandler ()
		{
			if (cb_setShareboardPostion_I == null)
				cb_setShareboardPostion_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetShareboardPostion_I);
			return cb_setShareboardPostion_I;
		}

		static IntPtr n_SetShareboardPostion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShareboardPostion (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setShareboardPostion_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setShareboardPostion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShareboardPostion", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetShareboardPostion_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetShareboardPostion (int p0)
		{
			if (id_setShareboardPostion_I == IntPtr.Zero)
				id_setShareboardPostion_I = JNIEnv.GetMethodID (class_ref, "setShareboardPostion", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShareboardPostion_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShareboardPostion", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStatusBarHeight_I;
#pragma warning disable 0169
		static Delegate GetSetStatusBarHeight_IHandler ()
		{
			if (cb_setStatusBarHeight_I == null)
				cb_setStatusBarHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetStatusBarHeight_I);
			return cb_setStatusBarHeight_I;
		}

		static IntPtr n_SetStatusBarHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStatusBarHeight (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setStatusBarHeight_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setStatusBarHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatusBarHeight", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetStatusBarHeight_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetStatusBarHeight (int p0)
		{
			if (id_setStatusBarHeight_I == IntPtr.Zero)
				id_setStatusBarHeight_I = JNIEnv.GetMethodID (class_ref, "setStatusBarHeight", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStatusBarHeight_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusBarHeight", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTitleText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitleText_Ljava_lang_String_Handler ()
		{
			if (cb_setTitleText_Ljava_lang_String_ == null)
				cb_setTitleText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTitleText_Ljava_lang_String_);
			return cb_setTitleText_Ljava_lang_String_;
		}

		static IntPtr n_SetTitleText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitleText (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTitleText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setTitleText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitleText", "(Ljava/lang/String;)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetTitleText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetTitleText (string p0)
		{
			if (id_setTitleText_Ljava_lang_String_ == IntPtr.Zero)
				id_setTitleText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitleText", "(Ljava/lang/String;)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTitleText_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitleText", "(Ljava/lang/String;)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTitleTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTitleTextColor_IHandler ()
		{
			if (cb_setTitleTextColor_I == null)
				cb_setTitleTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTitleTextColor_I);
			return cb_setTitleTextColor_I;
		}

		static IntPtr n_SetTitleTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitleTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setTitleTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setTitleTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitleTextColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetTitleTextColor_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetTitleTextColor (int p0)
		{
			if (id_setTitleTextColor_I == IntPtr.Zero)
				id_setTitleTextColor_I = JNIEnv.GetMethodID (class_ref, "setTitleTextColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTitleTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitleTextColor", "(I)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTitleVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetTitleVisibility_ZHandler ()
		{
			if (cb_setTitleVisibility_Z == null)
				cb_setTitleVisibility_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetTitleVisibility_Z);
			return cb_setTitleVisibility_Z;
		}

		static IntPtr n_SetTitleVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitleVisibility (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setTitleVisibility_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoardConfig']/method[@name='setTitleVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTitleVisibility", "(Z)Lcom/umeng/socialize/shareboard/ShareBoardConfig;", "GetSetTitleVisibility_ZHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig SetTitleVisibility (bool p0)
		{
			if (id_setTitleVisibility_Z == IntPtr.Zero)
				id_setTitleVisibility_Z = JNIEnv.GetMethodID (class_ref, "setTitleVisibility", "(Z)Lcom/umeng/socialize/shareboard/ShareBoardConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTitleVisibility_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitleVisibility", "(Z)Lcom/umeng/socialize/shareboard/ShareBoardConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
