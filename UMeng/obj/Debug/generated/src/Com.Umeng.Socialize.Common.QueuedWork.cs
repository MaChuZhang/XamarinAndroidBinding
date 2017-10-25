using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork']"
	[global::Android.Runtime.Register ("com/umeng/socialize/common/QueuedWork", DoNotGenerateAcw=true)]
	public partial class QueuedWork : global::Java.Lang.Object {


		static IntPtr isUseThreadPool_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork']/field[@name='isUseThreadPool']"
		[Register ("isUseThreadPool")]
		public static bool IsUseThreadPool {
			get {
				if (isUseThreadPool_jfieldId == IntPtr.Zero)
					isUseThreadPool_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUseThreadPool", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isUseThreadPool_jfieldId);
			}
			set {
				if (isUseThreadPool_jfieldId == IntPtr.Zero)
					isUseThreadPool_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUseThreadPool", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isUseThreadPool_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.DialogThread']"
		[global::Android.Runtime.Register ("com/umeng/socialize/common/QueuedWork$DialogThread", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public abstract partial class DialogThread : global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/common/QueuedWork$DialogThread", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DialogThread); }
			}

			protected DialogThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.DialogThread']/constructor[@name='QueuedWork.DialogThread' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe DialogThread (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (DialogThread)) {
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

		}

		[global::Android.Runtime.Register ("com/umeng/socialize/common/QueuedWork$DialogThread", DoNotGenerateAcw=true)]
		internal partial class DialogThreadInvoker : DialogThread {

			public DialogThreadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (DialogThreadInvoker); }
			}

			static IntPtr id_doInBackground;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.UMAsyncTask']/method[@name='doInBackground' and count(parameter)=0]"
			[Register ("doInBackground", "()Ljava/lang/Object;", "GetDoInBackgroundHandler")]
			protected override unsafe global::Java.Lang.Object DoInBackground ()
			{
				if (id_doInBackground == IntPtr.Zero)
					id_doInBackground = JNIEnv.GetMethodID (class_ref, "doInBackground", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.UMAsyncTask']"
		[global::Android.Runtime.Register ("com/umeng/socialize/common/QueuedWork$UMAsyncTask", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Result"})]
		public abstract partial class UMAsyncTask : global::Java.Lang.Object {


			static IntPtr thread_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.UMAsyncTask']/field[@name='thread']"
			[Register ("thread")]
			protected global::Java.Lang.IRunnable Thread {
				get {
					if (thread_jfieldId == IntPtr.Zero)
						thread_jfieldId = JNIEnv.GetFieldID (class_ref, "thread", "Ljava/lang/Runnable;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, thread_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (thread_jfieldId == IntPtr.Zero)
						thread_jfieldId = JNIEnv.GetFieldID (class_ref, "thread", "Ljava/lang/Runnable;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, thread_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/common/QueuedWork$UMAsyncTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UMAsyncTask); }
			}

			protected UMAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.UMAsyncTask']/constructor[@name='QueuedWork.UMAsyncTask' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe UMAsyncTask ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (UMAsyncTask)) {
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

			static Delegate cb_doInBackground;
#pragma warning disable 0169
			static Delegate GetDoInBackgroundHandler ()
			{
				if (cb_doInBackground == null)
					cb_doInBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DoInBackground);
				return cb_doInBackground;
			}

			static IntPtr n_DoInBackground (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DoInBackground ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.UMAsyncTask']/method[@name='doInBackground' and count(parameter)=0]"
			[Register ("doInBackground", "()Ljava/lang/Object;", "GetDoInBackgroundHandler")]
			protected abstract global::Java.Lang.Object DoInBackground ();

			static IntPtr id_execute;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.UMAsyncTask']/method[@name='execute' and count(parameter)=0]"
			[Register ("execute", "()Lcom/umeng/socialize/common/QueuedWork$UMAsyncTask;", "")]
			public unsafe global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask Execute ()
			{
				if (id_execute == IntPtr.Zero)
					id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()Lcom/umeng/socialize/common/QueuedWork$UMAsyncTask;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_onPostExecute_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Ljava_lang_Object_Handler ()
			{
				if (cb_onPostExecute_Ljava_lang_Object_ == null)
					cb_onPostExecute_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Object_);
				return cb_onPostExecute_Ljava_lang_Object_;
			}

			static void n_OnPostExecute_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPostExecute_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.UMAsyncTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='Result']]"
			[Register ("onPostExecute", "(Ljava/lang/Object;)V", "GetOnPostExecute_Ljava_lang_Object_Handler")]
			protected virtual unsafe void OnPostExecute (global::Java.Lang.Object p0)
			{
				if (id_onPostExecute_Ljava_lang_Object_ == IntPtr.Zero)
					id_onPostExecute_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostExecute_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Object;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onPreExecute;
#pragma warning disable 0169
			static Delegate GetOnPreExecuteHandler ()
			{
				if (cb_onPreExecute == null)
					cb_onPreExecute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPreExecute);
				return cb_onPreExecute;
			}

			static void n_OnPreExecute (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPreExecute ();
			}
#pragma warning restore 0169

			static IntPtr id_onPreExecute;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.UMAsyncTask']/method[@name='onPreExecute' and count(parameter)=0]"
			[Register ("onPreExecute", "()V", "GetOnPreExecuteHandler")]
			protected virtual unsafe void OnPreExecute ()
			{
				if (id_onPreExecute == IntPtr.Zero)
					id_onPreExecute = JNIEnv.GetMethodID (class_ref, "onPreExecute", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPreExecute);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreExecute", "()V"));
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/umeng/socialize/common/QueuedWork$UMAsyncTask", DoNotGenerateAcw=true)]
		internal partial class UMAsyncTaskInvoker : UMAsyncTask {

			public UMAsyncTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (UMAsyncTaskInvoker); }
			}

			static IntPtr id_doInBackground;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork.UMAsyncTask']/method[@name='doInBackground' and count(parameter)=0]"
			[Register ("doInBackground", "()Ljava/lang/Object;", "GetDoInBackgroundHandler")]
			protected override unsafe global::Java.Lang.Object DoInBackground ()
			{
				if (id_doInBackground == IntPtr.Zero)
					id_doInBackground = JNIEnv.GetMethodID (class_ref, "doInBackground", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/common/QueuedWork", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueuedWork); }
		}

		protected QueuedWork (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork']/constructor[@name='QueuedWork' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QueuedWork ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (QueuedWork)) {
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

		static IntPtr id_runInBack_Ljava_lang_Runnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork']/method[@name='runInBack' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='boolean']]"
		[Register ("runInBack", "(Ljava/lang/Runnable;Z)V", "")]
		public static unsafe void RunInBack (global::Java.Lang.IRunnable p0, bool p1)
		{
			if (id_runInBack_Ljava_lang_Runnable_Z == IntPtr.Zero)
				id_runInBack_Ljava_lang_Runnable_Z = JNIEnv.GetStaticMethodID (class_ref, "runInBack", "(Ljava/lang/Runnable;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_runInBack_Ljava_lang_Runnable_Z, __args);
			} finally {
			}
		}

		static IntPtr id_runInMain_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='QueuedWork']/method[@name='runInMain' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runInMain", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void RunInMain (global::Java.Lang.IRunnable p0)
		{
			if (id_runInMain_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_runInMain_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "runInMain", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_runInMain_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

	}
}
