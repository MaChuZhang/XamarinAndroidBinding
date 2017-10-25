using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Social.Tool {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']"
	[global::Android.Runtime.Register ("com/umeng/social/tool/UMImageMark", DoNotGenerateAcw=true)]
	public partial class UMImageMark : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/social/tool/UMImageMark", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMImageMark); }
		}

		protected UMImageMark (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/constructor[@name='UMImageMark' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UMImageMark ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UMImageMark)) {
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

		static Delegate cb_bringToFront;
#pragma warning disable 0169
		static Delegate GetBringToFrontHandler ()
		{
			if (cb_bringToFront == null)
				cb_bringToFront = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BringToFront);
			return cb_bringToFront;
		}

		static void n_BringToFront (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BringToFront ();
		}
#pragma warning restore 0169

		static IntPtr id_bringToFront;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='bringToFront' and count(parameter)=0]"
		[Register ("bringToFront", "()V", "GetBringToFrontHandler")]
		public virtual unsafe void BringToFront ()
		{
			if (id_bringToFront == IntPtr.Zero)
				id_bringToFront = JNIEnv.GetMethodID (class_ref, "bringToFront", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bringToFront);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bringToFront", "()V"));
			} finally {
			}
		}

		static Delegate cb_compound_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetCompound_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_compound_Landroid_graphics_Bitmap_ == null)
				cb_compound_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Compound_Landroid_graphics_Bitmap_);
			return cb_compound_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_Compound_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Compound (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compound_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='compound' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("compound", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "GetCompound_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Compound (global::Android.Graphics.Bitmap p0)
		{
			if (id_compound_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_compound_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "compound", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compound_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compound", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetAlpha_FHandler ()
		{
			if (cb_setAlpha_F == null)
				cb_setAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAlpha_F);
			return cb_setAlpha_F;
		}

		static void n_SetAlpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlpha_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
		public virtual unsafe void SetAlpha (float p0)
		{
			if (id_setAlpha_F == IntPtr.Zero)
				id_setAlpha_F = JNIEnv.GetMethodID (class_ref, "setAlpha", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlpha_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual unsafe void SetContext (global::Android.Content.Context p0)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContext_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContext", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setGravity_I;
#pragma warning disable 0169
		static Delegate GetSetGravity_IHandler ()
		{
			if (cb_setGravity_I == null)
				cb_setGravity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGravity_I);
			return cb_setGravity_I;
		}

		static void n_SetGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGravity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGravity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='setGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGravity", "(I)V", "GetSetGravity_IHandler")]
		public virtual unsafe void SetGravity (int p0)
		{
			if (id_setGravity_I == IntPtr.Zero)
				id_setGravity_I = JNIEnv.GetMethodID (class_ref, "setGravity", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGravity_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGravity", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMargins_IIII;
#pragma warning disable 0169
		static Delegate GetSetMargins_IIIIHandler ()
		{
			if (cb_setMargins_IIII == null)
				cb_setMargins_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_SetMargins_IIII);
			return cb_setMargins_IIII;
		}

		static void n_SetMargins_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMargins (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setMargins_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='setMargins' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setMargins", "(IIII)V", "GetSetMargins_IIIIHandler")]
		public virtual unsafe void SetMargins (int p0, int p1, int p2, int p3)
		{
			if (id_setMargins_IIII == IntPtr.Zero)
				id_setMargins_IIII = JNIEnv.GetMethodID (class_ref, "setMargins", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMargins_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMargins", "(IIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMarkBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetMarkBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setMarkBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setMarkBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarkBitmap_Landroid_graphics_Bitmap_);
			return cb_setMarkBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_SetMarkBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMarkBitmap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMarkBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='setMarkBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setMarkBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetMarkBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetMarkBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_setMarkBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setMarkBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setMarkBitmap", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMarkBitmap_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMarkBitmap", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRotate_I;
#pragma warning disable 0169
		static Delegate GetSetRotate_IHandler ()
		{
			if (cb_setRotate_I == null)
				cb_setRotate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRotate_I);
			return cb_setRotate_I;
		}

		static void n_SetRotate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRotate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='setRotate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRotate", "(I)V", "GetSetRotate_IHandler")]
		public virtual unsafe void SetRotate (int p0)
		{
			if (id_setRotate_I == IntPtr.Zero)
				id_setRotate_I = JNIEnv.GetMethodID (class_ref, "setRotate", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotate_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotate", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScale_F;
#pragma warning disable 0169
		static Delegate GetSetScale_FHandler ()
		{
			if (cb_setScale_F == null)
				cb_setScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScale_F);
			return cb_setScale_F;
		}

		static void n_SetScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setScale", "(F)V", "GetSetScale_FHandler")]
		public virtual unsafe void SetScale (float p0)
		{
			if (id_setScale_F == IntPtr.Zero)
				id_setScale_F = JNIEnv.GetMethodID (class_ref, "setScale", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScale_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTransparent;
#pragma warning disable 0169
		static Delegate GetSetTransparentHandler ()
		{
			if (cb_setTransparent == null)
				cb_setTransparent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetTransparent);
			return cb_setTransparent;
		}

		static void n_SetTransparent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Social.Tool.UMImageMark __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Social.Tool.UMImageMark> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTransparent ();
		}
#pragma warning restore 0169

		static IntPtr id_setTransparent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.social.tool']/class[@name='UMImageMark']/method[@name='setTransparent' and count(parameter)=0]"
		[Register ("setTransparent", "()V", "GetSetTransparentHandler")]
		public virtual unsafe void SetTransparent ()
		{
			if (id_setTransparent == IntPtr.Zero)
				id_setTransparent = JNIEnv.GetMethodID (class_ref, "setTransparent", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransparent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransparent", "()V"));
			} finally {
			}
		}

	}
}
