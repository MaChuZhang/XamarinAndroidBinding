using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Shareboard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']"
	[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/SocializeImageView", DoNotGenerateAcw=true)]
	public partial class SocializeImageView : global::Android.Widget.ImageButton {


		static IntPtr BG_SHAPE_CIRCULAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/field[@name='BG_SHAPE_CIRCULAR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/field[@name='BG_SHAPE_NONE']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/field[@name='BG_SHAPE_ROUNDED_SQUARE']"
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

		static IntPtr mNormalPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/field[@name='mNormalPaint']"
		[Register ("mNormalPaint")]
		protected global::Android.Graphics.Paint MNormalPaint {
			get {
				if (mNormalPaint_jfieldId == IntPtr.Zero)
					mNormalPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mNormalPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mNormalPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mNormalPaint_jfieldId == IntPtr.Zero)
					mNormalPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mNormalPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mNormalPaint_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPressedPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/field[@name='mPressedPaint']"
		[Register ("mPressedPaint")]
		protected global::Android.Graphics.Paint MPressedPaint {
			get {
				if (mPressedPaint_jfieldId == IntPtr.Zero)
					mPressedPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPressedPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPressedPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPressedPaint_jfieldId == IntPtr.Zero)
					mPressedPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPressedPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPressedPaint_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/shareboard/SocializeImageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeImageView); }
		}

		protected SocializeImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/constructor[@name='SocializeImageView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe SocializeImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (SocializeImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/constructor[@name='SocializeImageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SocializeImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SocializeImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/constructor[@name='SocializeImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SocializeImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SocializeImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/constructor[@name='SocializeImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SocializeImageView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SocializeImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_dip2px_F;
#pragma warning disable 0169
		static Delegate GetDip2px_FHandler ()
		{
			if (cb_dip2px_F == null)
				cb_dip2px_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int>) n_Dip2px_F);
			return cb_dip2px_F;
		}

		static int n_Dip2px_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Umeng.Socialize.Shareboard.SocializeImageView __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.SocializeImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dip2px (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dip2px_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/method[@name='dip2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("dip2px", "(F)I", "GetDip2px_FHandler")]
		protected virtual unsafe int Dip2px (float p0)
		{
			if (id_dip2px_F == IntPtr.Zero)
				id_dip2px_F = JNIEnv.GetMethodID (class_ref, "dip2px", "(F)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_dip2px_F, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dip2px", "(F)I"), __args);
			} finally {
			}
		}

		static Delegate cb_setBackgroundColor_II;
#pragma warning disable 0169
		static Delegate GetSetBackgroundColor_IIHandler ()
		{
			if (cb_setBackgroundColor_II == null)
				cb_setBackgroundColor_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetBackgroundColor_II);
			return cb_setBackgroundColor_II;
		}

		static void n_SetBackgroundColor_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Umeng.Socialize.Shareboard.SocializeImageView __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.SocializeImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundColor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundColor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/method[@name='setBackgroundColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setBackgroundColor", "(II)V", "GetSetBackgroundColor_IIHandler")]
		public virtual unsafe void SetBackgroundColor (int p0, int p1)
		{
			if (id_setBackgroundColor_II == IntPtr.Zero)
				id_setBackgroundColor_II = JNIEnv.GetMethodID (class_ref, "setBackgroundColor", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackgroundColor_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundColor", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBackgroundShape_I;
#pragma warning disable 0169
		static Delegate GetSetBackgroundShape_IHandler ()
		{
			if (cb_setBackgroundShape_I == null)
				cb_setBackgroundShape_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBackgroundShape_I);
			return cb_setBackgroundShape_I;
		}

		static void n_SetBackgroundShape_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.SocializeImageView __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.SocializeImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundShape (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundShape_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/method[@name='setBackgroundShape' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBackgroundShape", "(I)V", "GetSetBackgroundShape_IHandler")]
		public virtual unsafe void SetBackgroundShape (int p0)
		{
			if (id_setBackgroundShape_I == IntPtr.Zero)
				id_setBackgroundShape_I = JNIEnv.GetMethodID (class_ref, "setBackgroundShape", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackgroundShape_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundShape", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBackgroundShape_II;
#pragma warning disable 0169
		static Delegate GetSetBackgroundShape_IIHandler ()
		{
			if (cb_setBackgroundShape_II == null)
				cb_setBackgroundShape_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetBackgroundShape_II);
			return cb_setBackgroundShape_II;
		}

		static void n_SetBackgroundShape_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Umeng.Socialize.Shareboard.SocializeImageView __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.SocializeImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundShape (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundShape_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/method[@name='setBackgroundShape' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setBackgroundShape", "(II)V", "GetSetBackgroundShape_IIHandler")]
		public virtual unsafe void SetBackgroundShape (int p0, int p1)
		{
			if (id_setBackgroundShape_II == IntPtr.Zero)
				id_setBackgroundShape_II = JNIEnv.GetMethodID (class_ref, "setBackgroundShape", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackgroundShape_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundShape", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPressEffectEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetPressEffectEnable_ZHandler ()
		{
			if (cb_setPressEffectEnable_Z == null)
				cb_setPressEffectEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPressEffectEnable_Z);
			return cb_setPressEffectEnable_Z;
		}

		static void n_SetPressEffectEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Umeng.Socialize.Shareboard.SocializeImageView __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.SocializeImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPressEffectEnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPressEffectEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/method[@name='setPressEffectEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPressEffectEnable", "(Z)V", "GetSetPressEffectEnable_ZHandler")]
		public virtual unsafe void SetPressEffectEnable (bool p0)
		{
			if (id_setPressEffectEnable_Z == IntPtr.Zero)
				id_setPressEffectEnable_Z = JNIEnv.GetMethodID (class_ref, "setPressEffectEnable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPressEffectEnable_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPressEffectEnable", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPressedColor_I;
#pragma warning disable 0169
		static Delegate GetSetPressedColor_IHandler ()
		{
			if (cb_setPressedColor_I == null)
				cb_setPressedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPressedColor_I);
			return cb_setPressedColor_I;
		}

		static void n_SetPressedColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.SocializeImageView __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.SocializeImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPressedColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPressedColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SocializeImageView']/method[@name='setPressedColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPressedColor", "(I)V", "GetSetPressedColor_IHandler")]
		public virtual unsafe void SetPressedColor (int p0)
		{
			if (id_setPressedColor_I == IntPtr.Zero)
				id_setPressedColor_I = JNIEnv.GetMethodID (class_ref, "setPressedColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPressedColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPressedColor", "(I)V"), __args);
			} finally {
			}
		}

	}
}
