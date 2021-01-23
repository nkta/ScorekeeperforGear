S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20170403.0854
Build-Date: 2017.04.03 08:54:58

Crash Information
Process Name: scorekeeperforgear
PID: 6254
Date: 2017-06-19 07:13:24+0900
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x46

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb3db9294, esi = 0x00000000
ebp = 0xbfe442c8, esp = 0xbfe43674
eax = 0xffffffff, ebx = 0xb75e2ff4
ecx = 0x00000000, edx = 0xb75e4430
eip = 0xb74c3ec2

Memory Information
MemTotal:      123 KB
MemFree:        24 KB
Buffers:         5 KB
Cached:     132236 KB
VmPeak:      63252 KB
VmSize:      63252 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        6976 KB
VmRSS:        6976 KB
VmData:       2228 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32640 KB
VmPTE:          52 KB
VmSwap:          0 KB

Maps Information
b3b69000 b3b6c000 r-xp /usr/lib/libdri2.so.0.0.0
b3b6d000 b3b78000 r-xp /usr/lib/libdrm.so.2.4.0
b3b79000 b3b82000 r-xp /usr/lib/libtbm.so.1.0.0
b3b83000 b3b8a000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3b8b000 b3b94000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3b95000 b3b9c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3b9d000 b3ba5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3ba6000 b3baa000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3bab000 b3bc8000 r-xp /usr/lib/libtts.so
b3bc9000 b3bdf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
b3be0000 b3d24000 r-xp /usr/lib/libcairo.so.2.11200.14
b3d28000 b3d40000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3d41000 b3d47000 r-xp /usr/lib/libctx-client.so.0.8.3
b3d48000 b3d52000 r-xp /usr/lib/libctx-shared.so.0.8.3
b3d53000 b3d65000 r-xp /usr/lib/libdeviced.so.0.1.0
b3d66000 b3d89000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3d8a000 b3d9a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3d9b000 b3dac000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b3dae000 b3dbc000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
b3dbe000 b3dc9000 r-xp /lib/libnss_files-2.13.so
b3fcb000 b3ff2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3ff3000 b4018000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4019000 b413a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b414a000 b417f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4181000 b4184000 r-xp /usr/lib/libiniparser.so.0
b4186000 b4190000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b4191000 b419a000 r-xp /usr/lib/libappsvc.so.0.1.0
b419b000 b419e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b419f000 b41a5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b41a6000 b41ad000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b41ae000 b41b4000 r-xp /usr/lib/libogg.so.0.7.1
b41b5000 b41e0000 r-xp /usr/lib/libvorbis.so.0.4.3
b41e1000 b42cc000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42da000 b42dc000 r-xp /usr/lib/libXau.so.6.0.0
b42dd000 b4336000 r-xp /usr/lib/libssl.so.1.0.0
b433b000 b436c000 r-xp /usr/lib/libidn.so.11.5.44
b436d000 b437d000 r-xp /usr/lib/libcares.so.2.1.0
b437e000 b43e7000 r-xp /usr/lib/libsndfile.so.1.0.25
b43ed000 b43f9000 r-xp /usr/lib/libsensord-shared.so
b43fa000 b4420000 r-xp /lib/libexpat.so.1.5.2
b4422000 b4449000 r-xp /usr/lib/libpng12.so.0.50.0
b444a000 b446a000 r-xp /usr/lib/libxcb.so.1.1.0
b446b000 b44da000 r-xp /usr/lib/libcurl.so.4.3.0
b44dc000 b44e7000 r-xp /usr/lib/libethumb.so.1.7.99
b5d64000 b5e3c000 r-xp /usr/lib/libstdc++.so.6.0.16
b5e48000 b5e4b000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e4c000 b5e62000 r-xp /usr/lib/libremix.so.0.0.0
b5e63000 b5e65000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e66000 b5e92000 r-xp /usr/lib/liblua-5.1.so
b5e93000 b5e9d000 r-xp /usr/lib/libembryo.so.1.7.99
b5e9e000 b5ee4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ef5000 b5f24000 r-xp /usr/lib/libsensor.so.1.9.0
b5f25000 b5fa7000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5fac000 b5fe0000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5fe2000 b603d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b603f000 b6055000 r-xp /usr/lib/libfribidi.so.0.3.1
b6056000 b60e2000 r-xp /usr/lib/libfreetype.so.6.11.3
b60e6000 b60e9000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b60ea000 b60f0000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b60f1000 b60f7000 r-xp /usr/lib/libecore_fb.so.1.7.99
b60f9000 b610a000 r-xp /usr/lib/libXext.so.6.4.0
b610b000 b623f000 r-xp /usr/lib/libX11.so.6.3.0
b6243000 b6248000 r-xp /usr/lib/libXtst.so.6.1.0
b6249000 b6251000 r-xp /usr/lib/libXrender.so.1.3.0
b6252000 b625b000 r-xp /usr/lib/libXrandr.so.2.2.0
b625c000 b625e000 r-xp /usr/lib/libXinerama.so.1.0.0
b625f000 b626d000 r-xp /usr/lib/libXi.so.6.1.0
b626e000 b6272000 r-xp /usr/lib/libXfixes.so.3.1.0
b6273000 b6275000 r-xp /usr/lib/libXgesture.so.7.0.0
b6276000 b6278000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6279000 b627b000 r-xp /usr/lib/libXdamage.so.1.1.0
b627c000 b6285000 r-xp /usr/lib/libXcursor.so.1.0.2
b6286000 b62b1000 r-xp /usr/lib/libecore_con.so.1.7.99
b62b3000 b62bb000 r-xp /usr/lib/libecore_imf.so.1.7.99
b62bc000 b62c7000 r-xp /usr/lib/libethumb_client.so.1.7.99
b62c8000 b62ce000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b62cf000 b62f0000 r-xp /usr/lib/libefreet.so.1.7.99
b62f2000 b62fe000 r-xp /usr/lib/libedbus.so.1.7.99
b62ff000 b648e000 r-xp /usr/lib/libicuuc.so.57.1
b649d000 b6719000 r-xp /usr/lib/libicui18n.so.57.1
b6722000 b67c0000 r-xp /usr/lib/libedje.so.1.7.99
b67c2000 b67d3000 r-xp /usr/lib/libecore_input.so.1.7.99
b67d4000 b67db000 r-xp /usr/lib/libecore_file.so.1.7.99
b67dc000 b6802000 r-xp /usr/lib/libeet.so.1.7.99
b680b000 b6935000 r-xp /usr/lib/libevas.so.1.7.99
b6953000 b6987000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6989000 b69cd000 r-xp /usr/lib/libecore_x.so.1.7.99
b69cf000 b6bca000 r-xp /usr/lib/libelementary.so.1.7.99
b6bd9000 b6bdb000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b6bdc000 b6be2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6be3000 b6be7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6bec000 b6bed000 r-xp /usr/lib/libjournal.so.0.1.0
b6bee000 b6d36000 r-xp /usr/lib/libxml2.so.2.7.8
b6d3c000 b6d4f000 r-xp /lib/libresolv-2.13.so
b6d53000 b6d70000 r-xp /lib/libz.so.1.2.5
b6d71000 b6d74000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d76000 b6d7b000 r-xp /usr/lib/libffi.so.5.0.10
b6d7c000 b6d7d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d7e000 b6d82000 r-xp /lib/libattr.so.1.1.0
b6d83000 b6f96000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fb1000 b6fd2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fd4000 b6ffc000 r-xp /lib/libm-2.13.so
b6ffe000 b7059000 r-xp /usr/lib/libeina.so.1.7.99
b705b000 b7066000 r-xp /usr/lib/libvconf.so.0.2.45
b7067000 b706a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b706b000 b70b9000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70bb000 b721c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7220000 b7227000 r-xp /lib/librt-2.13.so
b7229000 b7230000 r-xp /usr/lib/libcapi-base-common.so.0.1.10
b7232000 b724c000 r-xp /lib/libgcc_s-4.6.4.so.1
b724d000 b7255000 r-xp /lib/libcrypt-2.13.so
b727f000 b7283000 r-xp /lib/libcap.so.2.21
b7284000 b7286000 r-xp /usr/lib/libiri.so
b7287000 b72b3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72b4000 b72d4000 r-xp /usr/lib/libecore.so.1.7.99
b72e3000 b72ec000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72ed000 b7410000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7412000 b7425000 r-xp /usr/lib/libail.so.0.1.0
b7426000 b744b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b744c000 b7456000 r-xp /lib/libunwind.so.8.0.1
b7460000 b75e0000 r-xp /lib/libc-2.13.so
b75e7000 b7631000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7633000 b7638000 r-xp /usr/lib/libbundle.so.0.1.22
b7639000 b763c000 r-xp /lib/libdl-2.13.so
b763e000 b7655000 r-xp /lib/libpthread-2.13.so
b7659000 b765c000 r-xp /usr/lib/libdlog.so.0.0.0
b765d000 b765f000 r-xp /usr/lib/libttrace.so.1.1
b7660000 b7665000 r-xp /usr/lib/libsmack.so.1.0.0
b7666000 b770e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7711000 b772b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b772c000 b773c000 r-xp /usr/lib/libaul.so.0.1.0
b773f000 b7745000 r-xp /usr/lib/libappcore-common.so.1.1
b7746000 b774b000 r-xp /usr/lib/libappcore-efl.so.1.1
b774d000 b7752000 r-xp /usr/lib/libsys-assert.so
b7755000 b7756000 r-xp [vdso]
b7756000 b7774000 r-xp /lib/ld-2.13.so
b7776000 b777d000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:6254)
Call Stack Count: 2
 0: fclose + 0x22 (0xb74c3ec2) [/lib/libc.so.6] + 0x63ec2
 1: __libc_start_main + 0xf3 (0xb74791a3) [/lib/libc.so.6] + 0x191a3
End of Call Stack

Package Information
Package Name: org.example.scorekeeperforgear
Package ID : org.example.scorekeeperforgear
Version: 1.0.0
Package Type: rpm
App Name: scorekeeperforgear
App ID: org.example.scorekeeperforgear
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
roc_action,669] appid org.tizen.crash-popup, pid 6121, type 4 
06-19 07:06:51.557+0900 D/RESOURCED( 2490): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 6121
06-19 07:06:51.557+0900 D/RESOURCED( 2490): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
06-19 07:06:51.557+0900 E/RESOURCED( 2490): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 251
06-19 07:06:51.557+0900 D/RESOURCED( 2490): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
06-19 07:06:51.607+0900 D/AUL_AMD ( 2307): amd_launch.c: __e17_status_handler(1939) > pid(6121) status(3)
06-19 07:06:51.607+0900 D/RESOURCED( 2490): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 6121, type = 0
06-19 07:06:51.607+0900 D/RESOURCED( 2490): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 6121
06-19 07:06:51.607+0900 I/RESOURCED( 2490): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 6121, oom : 200
06-19 07:06:51.607+0900 E/RESOURCED( 2490): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
06-19 07:06:51.607+0900 E/RESOURCED( 2490): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (6121) didn't have any process list
06-19 07:06:51.607+0900 D/RESOURCED( 2490): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 6121, appname = (null)
06-19 07:06:51.607+0900 D/RESOURCED( 2490): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 6121
06-19 07:06:51.627+0900 D/APP_CORE( 6121): appcore.c: __prt_ltime(183) > [APP 6121] first idle after reset: 975 msec
06-19 07:06:51.627+0900 D/APP_CORE( 6121): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:2000006 fully_obscured 0
06-19 07:06:51.627+0900 D/APP_CORE( 6121): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active -1
06-19 07:06:51.627+0900 D/APP_CORE( 6121): appcore-efl.c: __visibility_cb(900) >  Go to Resume state
06-19 07:06:51.627+0900 D/APP_CORE( 6121): appcore-efl.c: __do_app(471) > [APP 6121] Event: RESUME State: RUNNING
06-19 07:06:51.627+0900 D/LAUNCH  ( 6121): appcore-efl.c: __do_app(566) > [crash-popup:Application:resume:start]
06-19 07:06:51.627+0900 D/LAUNCH  ( 6121): appcore-efl.c: __do_app(580) > [crash-popup:Application:resume:done]
06-19 07:06:51.627+0900 D/LAUNCH  ( 6121): appcore-efl.c: __do_app(582) > [crash-popup:Application:Launching:done]
06-19 07:06:51.627+0900 D/APP_CORE( 6121): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
06-19 07:06:51.627+0900 E/APP_CORE( 6121): appcore-efl.c: __trm_app_info_send_socket(234) > access
06-19 07:06:52.457+0900 D/AUL_AMD ( 2307): amd_launch.c: __grab_timeout_handler(1222) > pid(6103) ecore_x_pointer_ungrab
06-19 07:06:52.457+0900 D/AUL_AMD ( 2307): amd_request.c: __add_history_handler(255) > [SECURE_LOG] add rua history org.example.scorekeeperforgear /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
06-19 07:06:52.457+0900 D/RUA     ( 2307): rua.c: rua_add_history(179) > rua_add_history start
06-19 07:06:52.457+0900 D/RUA     ( 2307): rua.c: rua_add_history(247) > rua_add_history ok
06-19 07:06:52.557+0900 D/AUL_AMD ( 2307): amd_request.c: __add_history_handler(255) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
06-19 07:06:52.557+0900 D/RUA     ( 2307): rua.c: rua_add_history(179) > rua_add_history start
06-19 07:06:52.557+0900 D/RUA     ( 2307): rua.c: rua_add_history(247) > rua_add_history ok
06-19 07:06:54.157+0900 I/GESTURE ( 2239): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-19 07:06:54.207+0900 D/EFL     ( 6121): ecore_x<6121> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=8166164 button=1
06-19 07:06:54.227+0900 D/EFL     ( 6121): ecore_x<6121> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=8166225 button=1
06-19 07:06:54.227+0900 E/EFL     ( 6121): eina_module<6121> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-19 07:06:54.227+0900 D/AUL     ( 6121): app_sock.c: __app_send_raw_with_noreply(370) > pid(-2) : cmd(22)
06-19 07:06:54.227+0900 D/AUL_AMD ( 2307): amd_request.c: __request_handler(506) > __request_handler: 22
06-19 07:06:54.227+0900 D/APP_CORE( 6121): appcore-efl.c: __after_loop(1081) > [APP 6121] PAUSE before termination
06-19 07:06:54.227+0900 E/W_HOME  ( 2376): main.c: _window_focus_in_cb(851) > win[27262979], ev->win[27262983]
06-19 07:06:54.227+0900 D/APPS    ( 2376): apps_main.c: _window_focus_in_cb(288) >  focus in
06-19 07:06:54.227+0900 E/W_HOME  ( 2376): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
06-19 07:06:54.227+0900 D/APPS    ( 2376): apps_main.c: apps_main_resume(693) >  Resume starts
06-19 07:06:54.227+0900 D/APPS    ( 2376): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
06-19 07:06:54.227+0900 E/efl-extension( 2376): efl_extension_rotary.c: eext_rotary_object_event_activated_set(299) > eext_rotary_object_event_activated_set : 0xb8114a18, elm_scroller, _activated_obj : 0xb8114a18, activated : 1
06-19 07:06:54.257+0900 I/AUL_PAD ( 2328): sigchild.h: __launchpad_sig_child(142) > dead_pid = 6121 pgid = 6121
06-19 07:06:54.257+0900 I/AUL_PAD ( 2328): sigchild.h: __sigchild_action(123) > dead_pid(6121)
06-19 07:06:54.257+0900 D/AUL_PAD ( 2328): sigchild.h: __send_app_dead_signal(81) > send dead signal done
06-19 07:06:54.257+0900 I/AUL_PAD ( 2328): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-19 07:06:54.257+0900 I/AUL_PAD ( 2328): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-19 07:06:54.267+0900 I/AUL_AMD ( 2307): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6121
06-19 07:06:54.267+0900 D/AUL_AMD ( 2307): amd_key.c: _unregister_key_event(161) > ===key stack===
06-19 07:06:54.267+0900 D/AUL     ( 2307): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-19 07:06:54.267+0900 E/AUL     ( 2307): simple_util.c: __trm_app_info_send_socket(264) > access
06-19 07:06:54.267+0900 D/STARTER ( 2372): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 6121)
06-19 07:06:54.267+0900 D/W_HOME  ( 2376): main.c: _dead_cb(542) > PID(6121) is dead
06-19 07:06:54.267+0900 E/W_HOME  ( 2376): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
06-19 07:06:56.237+0900 D/AUL_AMD ( 2307): amd_status.c: __app_terminate_timer_cb(113) > pid(6121)
06-19 07:06:56.237+0900 D/AUL_AMD ( 2307): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
06-19 07:07:00.247+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-19 07:07:00.247+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-19 07:07:00.247+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(clock_font_color) error
06-19 07:07:00.247+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-19 07:07:00.247+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-19 07:07:00.247+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(showdate) error
06-19 07:07:00.247+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(877) > show_date:1
06-19 07:07:00.247+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(11)[Mon, 19 Jun][1497823620]
06-19 07:07:00.247+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(885) > 
06-19 07:07:00.247+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[am][1497823620]
06-19 07:07:00.247+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[7:07][1497823620]
06-19 07:07:00.247+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(899) > utc_time=7:07, utc_ampm=[2]am
06-19 07:07:00.247+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>7:07<font_size=24><font=Tizen:style=Bold>am</font></font_size></color>
06-19 07:08:00.296+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-19 07:08:00.296+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-19 07:08:00.296+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(clock_font_color) error
06-19 07:08:00.296+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-19 07:08:00.296+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-19 07:08:00.296+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(showdate) error
06-19 07:08:00.296+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(877) > show_date:1
06-19 07:08:00.296+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(11)[Mon, 19 Jun][1497823680]
06-19 07:08:00.296+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(885) > 
06-19 07:08:00.296+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[am][1497823680]
06-19 07:08:00.296+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[7:08][1497823680]
06-19 07:08:00.296+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(899) > utc_time=7:08, utc_ampm=[2]am
06-19 07:08:00.296+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>7:08<font_size=24><font=Tizen:style=Bold>am</font></font_size></color>
06-19 07:09:00.365+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-19 07:09:00.365+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-19 07:09:00.365+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(clock_font_color) error
06-19 07:09:00.365+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-19 07:09:00.365+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-19 07:09:00.365+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(showdate) error
06-19 07:09:00.365+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(877) > show_date:1
06-19 07:09:00.365+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(11)[Mon, 19 Jun][1497823740]
06-19 07:09:00.365+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(885) > 
06-19 07:09:00.365+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[am][1497823740]
06-19 07:09:00.365+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[7:09][1497823740]
06-19 07:09:00.365+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(899) > utc_time=7:09, utc_ampm=[2]am
06-19 07:09:00.365+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>7:09<font_size=24><font=Tizen:style=Bold>am</font></font_size></color>
06-19 07:10:00.395+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-19 07:10:00.395+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-19 07:10:00.395+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(clock_font_color) error
06-19 07:10:00.395+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-19 07:10:00.395+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-19 07:10:00.395+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(showdate) error
06-19 07:10:00.395+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(877) > show_date:1
06-19 07:10:00.395+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(11)[Mon, 19 Jun][1497823800]
06-19 07:10:00.395+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(885) > 
06-19 07:10:00.395+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[am][1497823800]
06-19 07:10:00.395+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[7:10][1497823800]
06-19 07:10:00.395+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(899) > utc_time=7:10, utc_ampm=[2]am
06-19 07:10:00.395+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>7:10<font_size=24><font=Tizen:style=Bold>am</font></font_size></color>
06-19 07:11:00.454+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-19 07:11:00.454+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-19 07:11:00.454+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(clock_font_color) error
06-19 07:11:00.454+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-19 07:11:00.454+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-19 07:11:00.454+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(showdate) error
06-19 07:11:00.454+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(877) > show_date:1
06-19 07:11:00.454+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(11)[Mon, 19 Jun][1497823860]
06-19 07:11:00.454+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(885) > 
06-19 07:11:00.454+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[am][1497823860]
06-19 07:11:00.454+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[7:11][1497823860]
06-19 07:11:00.454+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(899) > utc_time=7:11, utc_ampm=[2]am
06-19 07:11:00.454+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>7:11<font_size=24><font=Tizen:style=Bold>am</font></font_size></color>
06-19 07:11:47.163+0900 D/DATA_PROVIDER_MASTER( 2417): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-19 07:11:47.163+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 2[0;m
06-19 07:11:47.163+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
06-19 07:11:47.163+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _device_state_changed_cb(1131) > DISPLAY STATE [1]
06-19 07:11:47.163+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _device_state_changed_cb(1155) > Not interested PM STATE
06-19 07:11:54.163+0900 W/STARTER ( 2372): clock-mgr.c: _notify_pm_lcdoff_cb(463) > [_notify_pm_lcdoff_cb:463] LCD OFF by lcd off source[2], wake_up_setting[1], ALPM_clock_state[0]
06-19 07:11:54.163+0900 E/STARTER ( 2372): clock-mgr.c: _notify_pm_lcdoff_cb(482) > [_notify_pm_lcdoff_cb:482] Failed to get [memory/setup_wizard/state]
06-19 07:11:54.163+0900 W/STARTER ( 2372): clock-mgr.c: _check_reserved_popup_status(93) > [_check_reserved_popup_status:93] Current reserved apps status : 0
06-19 07:11:54.163+0900 W/STARTER ( 2372): clock-mgr.c: _check_reserved_apps_status(127) > [_check_reserved_apps_status:127] Current reserved apps status : 0
06-19 07:11:54.163+0900 E/STARTER ( 2372): clock-mgr.c: _notify_pm_lcdoff_cb(666) > [_notify_pm_lcdoff_cb:666] Failed to get VCONFKEY_SETTING_SIMPLE_CLOCK_MODE
06-19 07:11:54.163+0900 W/STARTER ( 2372): clock-mgr.c: _check_reserved_apps_status(127) > [_check_reserved_apps_status:127] Current reserved apps status : 0
06-19 07:11:54.163+0900 W/STARTER ( 2372): clock-mgr.c: _notify_pm_lcdoff_cb(674) > [_notify_pm_lcdoff_cb:674] Not reserved apss status AND wake_up_setting is CLOCK => show simple clock..!!
06-19 07:11:54.163+0900 E/STARTER ( 2372): dbus-util_w.c: _dbus_message_send(149) > [_dbus_message_send:149] dbus_message_new_signal(/Org/Tizen/Coreapps/starter:org.tizen.coreapps.starter.alpmclock-show)
06-19 07:11:54.163+0900 D/STARTER ( 2372): dbus-util_w.c: _dbus_message_send(163) > [_dbus_message_send:163] dbus_connection_send, ret=1
06-19 07:11:54.163+0900 E/STARTER ( 2372): dbus-util_w.c: starter_dbus_alpm_clock_signal_send(187) > [starter_dbus_alpm_clock_signal_send:187] Sending alpmclock show signal, result:0
06-19 07:11:54.163+0900 D/STARTER ( 2372): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
06-19 07:11:54.163+0900 W/STARTER ( 2372): dbus-util_w.c: _on_lcd_changed_receive(632) > [_on_lcd_changed_receive:632] LCD off
06-19 07:11:54.163+0900 E/AUL_AMD ( 2307): amd_status.c: __lcd_status_cb(680) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
06-19 07:11:54.163+0900 W/W_HOME  ( 2376): dbus.c: _dbus_message_recv_cb(190) > LCD on
06-19 07:11:54.163+0900 E/W_HOME  ( 2376): dbus.c: _dbus_message_recv_cb(197) > Failed to get reply (org.freedesktop.DBus.Error.InvalidArgs:Argument 0 is specified to be of type "string", but is actually of type "invalid"
06-19 07:11:54.163+0900 E/W_HOME  ( 2376): )
06-19 07:11:54.163+0900 D/W_HOME  ( 2376): main.c: _lcd_off_cb(967) > LCD: on->off
06-19 07:11:54.273+0900 D/DATA_PROVIDER_MASTER( 2417): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-19 07:11:54.273+0900 D/W_HOME  ( 2376): clock_event.c: _display_state_cb(197) > LCD: on->off
06-19 07:11:54.273+0900 D/W_HOME  ( 2376): clock_view.c: clock_view_event_handler(843) > event:40001 received
06-19 07:11:54.273+0900 D/W_HOME  ( 2376): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:0, is_need_vi:0
06-19 07:11:54.273+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 3[0;m
06-19 07:11:54.273+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _device_state_changed_cb(1131) > DISPLAY STATE [2]
06-19 07:11:54.273+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
06-19 07:11:54.273+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:3,lock_state:0[0;m
06-19 07:11:54.273+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_configure_discovery(2040) > [0;36m BEGIN >>>>[0;m
06-19 07:11:54.273+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_configure_discovery(2055) > [0;36m Kill Thread[0;m
06-19 07:11:54.273+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_deinit(1892) > [0;36m BEGIN >>>>[0;m
06-19 07:11:54.273+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: _net_nfc_emul_controller_stop_thread(1842) > [0;36m BEGIN >>>>[0;m
06-19 07:11:54.773+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: _net_nfc_emul_controller_stop_thread(1852) > [0;36m END >>>>[0;m
06-19 07:11:54.773+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_deinit(1905) > [0;36m END >>>>[0;m
06-19 07:11:54.773+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_configure_discovery(2068) > [0;36m END >>>>[0;m
06-19 07:11:54.773+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_common.c: restart_polling_loop_thread_func(484) > [0;35mpolling disabled[0;m
06-19 07:12:00.463+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-19 07:12:00.463+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-19 07:12:00.463+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(clock_font_color) error
06-19 07:12:00.463+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-19 07:12:00.463+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-19 07:12:00.463+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(showdate) error
06-19 07:12:00.463+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(877) > show_date:1
06-19 07:12:00.463+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(11)[Mon, 19 Jun][1497823920]
06-19 07:12:00.463+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(885) > 
06-19 07:12:00.463+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[am][1497823920]
06-19 07:12:00.463+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[7:12][1497823920]
06-19 07:12:00.463+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(899) > utc_time=7:12, utc_ampm=[2]am
06-19 07:12:00.463+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>7:12<font_size=24><font=Tizen:style=Bold>am</font></font_size></color>
06-19 07:13:23.432+0900 D/W_HOME  ( 2376): clock_event.c: _display_state_cb(194) > LCD: off->on
06-19 07:13:23.432+0900 D/W_HOME  ( 2376): clock_view.c: clock_view_event_handler(843) > event:40000 received
06-19 07:13:23.432+0900 D/W_HOME  ( 2376): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
06-19 07:13:23.432+0900 D/DATA_PROVIDER_MASTER( 2417): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-19 07:13:23.432+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
06-19 07:13:23.432+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
06-19 07:13:23.432+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_configure_discovery(2040) > [0;36m BEGIN >>>>[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_configure_discovery(2063) > [0;36m Create Thread[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_init(1863) > [0;36m BEGIN >>>>[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_init(1865) > [0;36m start stack init [0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: _net_nfc_emul_controller_start_thread(1828) > [0;36m BEGIN >>>>[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: _net_nfc_emul_controller_start_thread(1835) > [0;36m END >>>>[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_init(1880) > [0;36m Stack init finished[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_init(1885) > [0;36m END >>>>[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: net_nfc_emul_controller_configure_discovery(2068) > [0;36m END >>>>[0;m
06-19 07:13:23.432+0900 D/NET_NFC_MANAGER( 2424): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: emul_ReaderThread(1635) > [0;36m emul_ReaderThread START >>>>[0;m
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: emul_ReaderThread(1646) > file path : /dev/nfc0
06-19 07:13:23.432+0900 E/NFC_PLUGIN_EMUL( 2424): oem_emul.c: emul_ReaderThread(1687) > [0;36m epoll wait >>>>[0;m
06-19 07:13:23.432+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _device_state_changed_cb(1131) > DISPLAY STATE [0]
06-19 07:13:23.432+0900 D/STARTER ( 2372): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
06-19 07:13:23.432+0900 W/STARTER ( 2372): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
06-19 07:13:23.432+0900 W/W_HOME  ( 2376): dbus.c: _dbus_message_recv_cb(178) > LCD on
06-19 07:13:23.432+0900 W/W_HOME  ( 2376): main.c: _lcd_on_cb(951) > LCD: off->on
06-19 07:13:23.432+0900 E/AUL_AMD ( 2307): amd_status.c: __lcd_status_cb(680) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
06-19 07:13:23.432+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: on_changed_receive(1293) > org.tizen.system.deviced.display - LCDOn
06-19 07:13:23.432+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
06-19 07:13:23.432+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
06-19 07:13:23.432+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(clock_font_color) error
06-19 07:13:23.432+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
06-19 07:13:23.432+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
06-19 07:13:23.432+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2380): preference.c: preference_get_int(1063) > preference_get_int(2380) : key(showdate) error
06-19 07:13:23.432+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(877) > show_date:1
06-19 07:13:23.432+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(11)[Mon, 19 Jun][1497824003]
06-19 07:13:23.432+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(885) > 
06-19 07:13:23.432+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[am][1497824003]
06-19 07:13:23.432+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[7:13][1497824003]
06-19 07:13:23.432+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(899) > utc_time=7:13, utc_ampm=[2]am
06-19 07:13:23.432+0900 D/IDLE-CLOCK-DIGITAL( 2380): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>7:13<font_size=24><font=Tizen:style=Bold>am</font></font_size></color>
06-19 07:13:23.492+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.492+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555501
06-19 07:13:23.492+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.492+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.492+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.492+0900 E/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8114a18, elm_scroller, 1
06-19 07:13:23.492+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(542) > Deliver clockwise rotary event to object: 0xb8114a18, elm_scroller, time_stamp : 8555501
06-19 07:13:23.492+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(62) >  Rotary callback is called
06-19 07:13:23.492+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(67) >  Detent detected, obj[0xb8114a18], direction[0], timeStamp[8555501]
06-19 07:13:23.492+0900 D/APPS    ( 2376): scroller.c: apps_scroller_bring_in_region_by_vector(1206) >  Apps scroller bring in region by vector: 1
06-19 07:13:23.492+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.492+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555501
06-19 07:13:23.492+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.492+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.492+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.492+0900 E/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8ce52b8, WRT_VIEW, 1
06-19 07:13:23.492+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb0114ca8
06-19 07:13:23.492+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb81ac598
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555661
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.652+0900 E/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8114a18, elm_scroller, 1
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(542) > Deliver clockwise rotary event to object: 0xb8114a18, elm_scroller, time_stamp : 8555661
06-19 07:13:23.652+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(62) >  Rotary callback is called
06-19 07:13:23.652+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(67) >  Detent detected, obj[0xb8114a18], direction[0], timeStamp[8555661]
06-19 07:13:23.652+0900 D/APPS    ( 2376): scroller.c: apps_scroller_bring_in_region_by_vector(1206) >  Apps scroller bring in region by vector: 1
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb8076020
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555662
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.652+0900 E/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8114a18, elm_scroller, 1
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(542) > Deliver clockwise rotary event to object: 0xb8114a18, elm_scroller, time_stamp : 8555662
06-19 07:13:23.652+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(62) >  Rotary callback is called
06-19 07:13:23.652+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(67) >  Detent detected, obj[0xb8114a18], direction[0], timeStamp[8555662]
06-19 07:13:23.652+0900 D/APPS    ( 2376): scroller.c: apps_scroller_bring_in_region_by_vector(1206) >  Apps scroller bring in region by vector: 1
06-19 07:13:23.652+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb810fa60
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555661
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555662
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.652+0900 E/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8ce52b8, WRT_VIEW, 1
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.652+0900 E/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8ce52b8, WRT_VIEW, 1
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb010f720
06-19 07:13:23.652+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb0114ca8
06-19 07:13:23.682+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.682+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555692
06-19 07:13:23.682+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.682+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.682+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.682+0900 E/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8114a18, elm_scroller, 1
06-19 07:13:23.682+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(542) > Deliver clockwise rotary event to object: 0xb8114a18, elm_scroller, time_stamp : 8555692
06-19 07:13:23.682+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(62) >  Rotary callback is called
06-19 07:13:23.682+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(67) >  Detent detected, obj[0xb8114a18], direction[0], timeStamp[8555692]
06-19 07:13:23.682+0900 D/APPS    ( 2376): scroller.c: apps_scroller_bring_in_region_by_vector(1206) >  Apps scroller bring in region by vector: 1
06-19 07:13:23.682+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb81c1a30
06-19 07:13:23.682+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.682+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555692
06-19 07:13:23.682+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.682+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.682+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.682+0900 E/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8ce52b8, WRT_VIEW, 1
06-19 07:13:23.682+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb0114ca8
06-19 07:13:23.752+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.752+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555757
06-19 07:13:23.752+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.752+0900 I/efl-extension( 2376): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.752+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.752+0900 E/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8114a18, elm_scroller, 1
06-19 07:13:23.752+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_handler_cb(542) > Deliver clockwise rotary event to object: 0xb8114a18, elm_scroller, time_stamp : 8555757
06-19 07:13:23.752+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(62) >  Rotary callback is called
06-19 07:13:23.752+0900 D/APPS    ( 2376): scroller.c: _rotary_cb(67) >  Detent detected, obj[0xb8114a18], direction[0], timeStamp[8555757]
06-19 07:13:23.752+0900 D/APPS    ( 2376): scroller.c: apps_scroller_bring_in_region_by_vector(1206) >  Apps scroller bring in region by vector: 1
06-19 07:13:23.752+0900 I/efl-extension( 2376): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb820fa38
06-19 07:13:23.752+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 07:13:23.752+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 8555757
06-19 07:13:23.752+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 07:13:23.752+0900 I/efl-extension( 2379): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 07:13:23.752+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 07:13:23.752+0900 E/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb8ce52b8, WRT_VIEW, 1
06-19 07:13:23.752+0900 I/efl-extension( 2379): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb010f720
06-19 07:13:24.722+0900 I/GESTURE ( 2239): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-19 07:13:24.772+0900 D/EFL     ( 2376): ecore_x<2376> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=8556729 button=1
06-19 07:13:24.772+0900 D/APPS    ( 2376): scroller.c: _mouse_down_cb(100) >  Mouse is down [191,168]
06-19 07:13:24.772+0900 D/APPS    ( 2376): item.c: _down_cb(381) >  Down (scorekeeperforgear,0xb80d5960) (191, 168), item pos(41,1,280,390)
06-19 07:13:24.772+0900 E/APPS    ( 2376): item.c: _down_cb(425) >  longpress edit mode disable
06-19 07:13:24.772+0900 W/APPS    ( 2376): item.c: _anim_item_pressed_cb(1046) >  item is pressed
06-19 07:13:24.842+0900 D/EFL     ( 2376): ecore_x<2376> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=8556851 button=1
06-19 07:13:24.842+0900 D/APPS    ( 2376): scroller.c: _mouse_up_cb(111) >  Mouse is up [191,171]
06-19 07:13:24.842+0900 D/APPS    ( 2376): item.c: _up_cb(573) >  Up (scorekeeperforgear,0xb80d5960) (191, 171), item pos(41,1,280,390)
06-19 07:13:24.842+0900 E/APPS    ( 2376): item.c: _clicked_cb(65) >  Clicked
06-19 07:13:24.842+0900 E/APPS    ( 2376): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
06-19 07:13:24.842+0900 D/APPS    ( 2376): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
06-19 07:13:24.842+0900 D/APP_SVC ( 2376): appsvc.c: __set_bundle(161) > __set_bundle
06-19 07:13:24.842+0900 D/APP_SVC ( 2376): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
06-19 07:13:24.842+0900 D/APP_SVC ( 2376): appsvc.c: __set_bundle(161) > __set_bundle
06-19 07:13:24.842+0900 D/W_HOME  ( 2376): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
06-19 07:13:24.842+0900 D/W_HOME  ( 2376): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
06-19 07:13:24.842+0900 D/APP_SVC ( 2376): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.scorekeeperforgear - no result
06-19 07:13:24.842+0900 D/AUL     ( 2376): launch.c: app_request_to_launchpad(287) > [SECURE_LOG] launch request : org.example.scorekeeperforgear
06-19 07:13:24.842+0900 D/AUL     ( 2376): app_sock.c: __app_send_raw(270) > pid(-2) : cmd(0)
06-19 07:13:24.842+0900 D/AUL_AMD ( 2307): amd_request.c: __request_handler(506) > __request_handler: 0
06-19 07:13:24.842+0900 D/AUL_AMD ( 2307): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.scorekeeperforgear
06-19 07:13:24.842+0900 D/AUL_AMD ( 2307): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : org.tizen.w-home
06-19 07:13:24.842+0900 E/AUL_AMD ( 2307): amd_launch.c: invoke_dbus_method_sync(1200) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
06-19 07:13:24.842+0900 D/AUL_AMD ( 2307): amd_launch.c: _start_app(1708) > org.tizen.system.coord.rotation-Degree : -74
06-19 07:13:24.842+0900 D/AUL_AMD ( 2307): amd_launch.c: _start_app(1803) > process_pool: false
06-19 07:13:24.842+0900 D/AUL_AMD ( 2307): amd_launch.c: _start_app(1806) > h/w acceleration: SYS
06-19 07:13:24.842+0900 D/AUL_AMD ( 2307): amd_launch.c: _start_app(1808) > [SECURE_LOG] appid: org.example.scorekeeperforgear
06-19 07:13:24.842+0900 D/AUL_AMD ( 2307): amd_launch.c: __set_appinfo_for_launchpad(1978) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-19 07:13:24.842+0900 D/AUL     ( 2307): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
06-19 07:13:24.842+0900 D/AUL_PAD ( 2328): launchpad.c: __launchpad_main_loop(644) > [SECURE_LOG] pkg name : org.example.scorekeeperforgear
06-19 07:13:24.842+0900 D/AUL_PAD ( 2328): launchpad.c: __modify_bundle(381) > parsing app_path: No arguments
06-19 07:13:24.842+0900 D/AUL_PAD ( 2328): launchpad.c: __launchpad_main_loop(704) > [SECURE_LOG] ==> real launch pid : 6254 /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __launchpad_main_loop(671) > lock up test log(no error) : fork done
06-19 07:13:24.842+0900 D/AUL_PAD ( 2328): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __launchpad_main_loop(682) > lock up test log(no error) : prepare exec - first done
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __prepare_exec(137) > [SECURE_LOG] pkg_name : org.example.scorekeeperforgear / pkg_type : rpm / app_path : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear 
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __launchpad_main_loop(697) > lock up test log(no error) : prepare exec - second done
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear##
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
06-19 07:13:24.842+0900 D/AUL_PAD ( 6254): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
06-19 07:13:24.842+0900 D/LAUNCH  ( 6254): launchpad.c: __real_launch(230) > [SECURE_LOG] [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear:Platform:launchpad:done]
06-19 07:13:24.852+0900 I/efl-extension( 6254): efl_extension.c: eext_mod_init(39) > Init
06-19 07:13:24.862+0900 I/AUL_PAD ( 2328): sigchild.h: __launchpad_sig_child(142) > dead_pid = 6254 pgid = 6254
06-19 07:13:24.862+0900 I/AUL_PAD ( 2328): sigchild.h: __sigchild_action(123) > dead_pid(6254)
06-19 07:13:24.862+0900 D/AUL_PAD ( 2328): sigchild.h: __send_app_dead_signal(81) > send dead signal done
06-19 07:13:24.862+0900 I/AUL_PAD ( 2328): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-19 07:13:24.862+0900 I/AUL_PAD ( 2328): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-19 07:13:24.862+0900 E/AUL_PAD ( 2328): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 6254
06-19 07:13:24.862+0900 D/AUL_PAD ( 2328): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 07:13:24.862+0900 D/STARTER ( 2372): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 6254)
06-19 07:13:24.872+0900 W/CRASH_MANAGER( 6255): worker.c: worker_job(1189) > 110625473636f149782400
