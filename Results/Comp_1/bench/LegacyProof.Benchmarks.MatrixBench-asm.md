## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply4x4()
       push      rbx
       sub       rsp,0A0
       mov       rbx,rdx
       vmovdqu   ymm0,ymmword ptr [rcx+8]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+28]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+48]
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+68]
       vmovdqu   ymmword ptr [rsp+40],ymm0
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FF853266088]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 92
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       sub       rsp,58
       vmovaps   [rsp+40],xmm6
       vmovaps   [rsp+30],xmm7
       vmovaps   [rsp+20],xmm8
       vmovaps   [rsp+10],xmm9
       vmovaps   [rsp],xmm10
       vmovups   xmm0,[rdx]
       vmovups   xmm1,[rdx+10]
       vmovups   xmm2,[rdx+20]
       vmovups   xmm3,[rdx+30]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm6,[r8+20]
       vmovups   xmm7,[r8+30]
       vunpckhps xmm8,xmm0,xmm0
       vbroadcastss xmm8,xmm8
       vmovshdup xmm9,xmm0
       vbroadcastss xmm9,xmm9
       vmovaps   xmm10,xmm0
       vbroadcastss xmm10,xmm10
       vmulps    xmm10,xmm10,xmm4
       vfmadd231ps xmm10,xmm9,xmm5
       vfmadd231ps xmm10,xmm8,xmm6
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm10,xmm0,xmm7
       vunpckhps xmm0,xmm1,xmm1
       vbroadcastss xmm0,xmm0
       vmovshdup xmm8,xmm1
       vbroadcastss xmm8,xmm8
       vmovaps   xmm9,xmm1
       vbroadcastss xmm9,xmm9
       vmulps    xmm9,xmm9,xmm4
       vfmadd231ps xmm9,xmm8,xmm5
       vfmadd231ps xmm9,xmm0,xmm6
       vshufps   xmm0,xmm1,xmm1,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm9,xmm0,xmm7
       vunpckhps xmm0,xmm2,xmm2
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm2
       vbroadcastss xmm1,xmm1
       vmovaps   xmm8,xmm2
       vbroadcastss xmm8,xmm8
       vmulps    xmm8,xmm8,xmm4
       vfmadd231ps xmm8,xmm1,xmm5
       vfmadd231ps xmm8,xmm0,xmm6
       vshufps   xmm0,xmm2,xmm2,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm8,xmm0,xmm7
       vunpckhps xmm0,xmm3,xmm3
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm3
       vbroadcastss xmm1,xmm1
       vmovaps   xmm2,xmm3
       vbroadcastss xmm2,xmm2
       vmulps    xmm2,xmm2,xmm4
       vfmadd213ps xmm5,xmm1,xmm2
       vfmadd213ps xmm6,xmm0,xmm5
       vshufps   xmm0,xmm3,xmm3,0FF
       vbroadcastss xmm0,xmm0
       vfmadd213ps xmm7,xmm0,xmm6
       vmovups   [rcx],xmm10
       vmovups   [rcx+10],xmm9
       vmovups   [rcx+20],xmm8
       vmovups   [rcx+30],xmm7
       mov       rax,rcx
       vmovaps   xmm6,[rsp+40]
       vmovaps   xmm7,[rsp+30]
       vmovaps   xmm8,[rsp+20]
       vmovaps   xmm9,[rsp+10]
       vmovaps   xmm10,[rsp]
       add       rsp,58
       ret
; Total bytes of code 355
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Add4x4()
       push      rbx
       sub       rsp,0A0
       mov       rbx,rdx
       vmovdqu   ymm0,ymmword ptr [rcx+8]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+28]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+48]
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+68]
       vmovdqu   ymmword ptr [rsp+40],ymm0
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FF853266070]; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 92
```
```assembly
; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       sub       rsp,28
       vmovaps   [rsp+10],xmm6
       vmovaps   [rsp],xmm7
       vmovups   xmm0,[rdx]
       vmovups   xmm1,[rdx+10]
       vmovups   xmm2,[rdx+20]
       vmovups   xmm3,[rdx+30]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm6,[r8+20]
       vmovups   xmm7,[r8+30]
       vaddps    xmm0,xmm0,xmm4
       vaddps    xmm1,xmm1,xmm5
       vaddps    xmm2,xmm2,xmm6
       vaddps    xmm3,xmm3,xmm7
       vmovups   [rcx],xmm0
       vmovups   [rcx+10],xmm1
       vmovups   [rcx+20],xmm2
       vmovups   [rcx+30],xmm3
       mov       rax,rcx
       vmovaps   xmm6,[rsp+10]
       vmovaps   xmm7,[rsp]
       add       rsp,28
       ret
; Total bytes of code 111
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply3x2()
       push      rbx
       sub       rsp,50
       mov       rbx,rdx
       vmovdqu   xmm0,xmmword ptr [rcx+88]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rdx,[rcx+98]
       mov       [rsp+48],rdx
       vmovdqu   xmm0,xmmword ptr [rcx+0A0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       rdx,[rcx+0B0]
       mov       [rsp+30],rdx
       lea       rdx,[rsp+38]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FF853285F98]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       ret
; Total bytes of code 88
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       sub       rsp,88
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       vmovaps   [rsp+40],xmm9
       vmovaps   [rsp+30],xmm10
       vmovaps   [rsp+20],xmm11
       vmovaps   [rsp+10],xmm12
       vmovaps   [rsp],xmm13
       vmovss    xmm0,dword ptr [rdx]
       vmovss    xmm1,dword ptr [rdx+4]
       vmovss    xmm2,dword ptr [rdx+8]
       vmovss    xmm3,dword ptr [rdx+0C]
       vmovss    xmm4,dword ptr [rdx+10]
       vmovss    xmm5,dword ptr [rdx+14]
       vmovss    xmm6,dword ptr [r8]
       vmovss    xmm7,dword ptr [r8+4]
       vmovss    xmm8,dword ptr [r8+8]
       vmovss    xmm9,dword ptr [r8+0C]
       vmovss    xmm10,dword ptr [r8+10]
       vmovss    xmm11,dword ptr [r8+14]
       vmulss    xmm12,xmm0,xmm6
       vmulss    xmm13,xmm1,xmm8
       vaddss    xmm12,xmm12,xmm13
       vmulss    xmm0,xmm0,xmm7
       vmulss    xmm1,xmm1,xmm9
       vaddss    xmm0,xmm0,xmm1
       vinsertps xmm0,xmm12,xmm0,1C
       vmulss    xmm1,xmm2,xmm6
       vmulss    xmm12,xmm3,xmm8
       vaddss    xmm1,xmm1,xmm12
       vmulss    xmm2,xmm2,xmm7
       vmulss    xmm3,xmm3,xmm9
       vaddss    xmm2,xmm2,xmm3
       vinsertps xmm1,xmm1,xmm2,1C
       vmulss    xmm2,xmm4,xmm6
       vmulss    xmm3,xmm5,xmm8
       vaddss    xmm2,xmm2,xmm3
       vaddss    xmm2,xmm2,xmm10
       vmulss    xmm3,xmm4,xmm7
       vmulss    xmm4,xmm5,xmm9
       vaddss    xmm3,xmm3,xmm4
       vaddss    xmm3,xmm3,xmm11
       vinsertps xmm2,xmm2,xmm3,1C
       vmovsd    qword ptr [rcx],xmm0
       vmovsd    qword ptr [rcx+8],xmm1
       vmovsd    qword ptr [rcx+10],xmm2
       mov       rax,rcx
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       vmovaps   xmm9,[rsp+40]
       vmovaps   xmm10,[rsp+30]
       vmovaps   xmm11,[rsp+20]
       vmovaps   xmm12,[rsp+10]
       vmovaps   xmm13,[rsp]
       add       rsp,88
       ret
; Total bytes of code 298
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply4x4()
       push      rbx
       sub       rsp,0A0
       vzeroupper
       mov       rbx,rdx
       vmovdqu   ymm0,ymmword ptr [rcx+8]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+28]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+48]
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+68]
       vmovdqu   ymmword ptr [rsp+40],ymm0
       mov       rcx,rbx
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       call      qword ptr [7FF84C31DEC0]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 92
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       push      rbx
       sub       rsp,0E0
       vzeroupper
       mov       rbx,rcx
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+0C0],ymm0
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       lea       rcx,[rsp+20]
       lea       rdx,[rsp+0A0]
       lea       r8,[rsp+60]
       call      qword ptr [7FF84C26FA20]; System.Numerics.Matrix4x4+Impl.op_Multiply(Impl ByRef, Impl ByRef)
       vmovdqu   ymm0,ymmword ptr [rsp+20]
       vmovdqu   ymmword ptr [rbx],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+40]
       vmovdqu   ymmword ptr [rbx+20],ymm0
       mov       rax,rbx
       add       rsp,0E0
       pop       rbx
       ret
; Total bytes of code 124
```
```assembly
; System.Numerics.Matrix4x4+Impl.op_Multiply(Impl ByRef, Impl ByRef)
       sub       rsp,28
       vzeroupper
       vmovaps   [rsp+10],xmm6
       vmovaps   [rsp],xmm7
       vmovups   xmm0,[r8]
       vbroadcastss xmm1,dword ptr [rdx]
       vmulps    xmm1,xmm0,xmm1
       vmovups   xmm2,[r8+10]
       vbroadcastss xmm3,dword ptr [rdx+4]
       vmulps    xmm3,xmm2,xmm3
       vaddps    xmm1,xmm1,xmm3
       vmovups   xmm3,[r8+20]
       vbroadcastss xmm4,dword ptr [rdx+8]
       vmulps    xmm4,xmm3,xmm4
       vaddps    xmm1,xmm1,xmm4
       vmovups   xmm4,[r8+30]
       vbroadcastss xmm5,dword ptr [rdx+0C]
       vmulps    xmm5,xmm4,xmm5
       vaddps    xmm1,xmm1,xmm5
       vbroadcastss xmm5,dword ptr [rdx+10]
       vmulps    xmm5,xmm0,xmm5
       vbroadcastss xmm6,dword ptr [rdx+14]
       vmulps    xmm6,xmm2,xmm6
       vaddps    xmm5,xmm5,xmm6
       vbroadcastss xmm6,dword ptr [rdx+18]
       vmulps    xmm6,xmm3,xmm6
       vaddps    xmm5,xmm5,xmm6
       vbroadcastss xmm6,dword ptr [rdx+1C]
       vmulps    xmm6,xmm4,xmm6
       vaddps    xmm5,xmm5,xmm6
       vbroadcastss xmm6,dword ptr [rdx+20]
       vmulps    xmm6,xmm0,xmm6
       vbroadcastss xmm7,dword ptr [rdx+24]
       vmulps    xmm7,xmm2,xmm7
       vaddps    xmm6,xmm6,xmm7
       vbroadcastss xmm7,dword ptr [rdx+28]
       vmulps    xmm7,xmm3,xmm7
       vaddps    xmm6,xmm6,xmm7
       vbroadcastss xmm7,dword ptr [rdx+2C]
       vmulps    xmm7,xmm4,xmm7
       vaddps    xmm6,xmm6,xmm7
       vbroadcastss xmm7,dword ptr [rdx+30]
       vmulps    xmm0,xmm0,xmm7
       vbroadcastss xmm7,dword ptr [rdx+34]
       vmulps    xmm2,xmm2,xmm7
       vaddps    xmm0,xmm0,xmm2
       vbroadcastss xmm2,dword ptr [rdx+38]
       vmulps    xmm2,xmm3,xmm2
       vaddps    xmm0,xmm0,xmm2
       vbroadcastss xmm2,dword ptr [rdx+3C]
       vmulps    xmm2,xmm4,xmm2
       vaddps    xmm0,xmm0,xmm2
       vmovups   [rcx],xmm1
       vmovups   [rcx+10],xmm5
       vmovups   [rcx+20],xmm6
       vmovups   [rcx+30],xmm0
       mov       rax,rcx
       vmovaps   xmm6,[rsp+10]
       vmovaps   xmm7,[rsp]
       add       rsp,28
       ret
; Total bytes of code 286
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Add4x4()
       push      rbx
       sub       rsp,0A0
       vzeroupper
       mov       rbx,rdx
       vmovdqu   ymm0,ymmword ptr [rcx+8]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+28]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+48]
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+68]
       vmovdqu   ymmword ptr [rsp+40],ymm0
       mov       rcx,rbx
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       call      qword ptr [7FF84C3ADEF0]; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 92
```
```assembly
; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       sub       rsp,48
       vzeroupper
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+8],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovups   xmm0,[r8]
       vmovups   xmm1,[r8+10]
       vmovups   xmm2,[r8+20]
       vmovups   xmm3,[r8+30]
       lea       rax,[rsp+8]
       vaddps    xmm0,xmm0,[rax]
       vaddps    xmm1,xmm1,[rax+10]
       vaddps    xmm2,xmm2,[rax+20]
       vaddps    xmm3,xmm3,[rax+30]
       vmovups   [rcx],xmm0
       vmovups   [rcx+10],xmm1
       vmovups   [rcx+20],xmm2
       vmovups   [rcx+30],xmm3
       mov       rax,rcx
       add       rsp,48
       ret
; Total bytes of code 102
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply3x2()
       push      rbx
       sub       rsp,50
       vzeroupper
       mov       rbx,rdx
       vmovdqu   xmm0,xmmword ptr [rcx+88]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rdx,[rcx+98]
       mov       [rsp+48],rdx
       vmovdqu   xmm0,xmmword ptr [rcx+0A0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       rdx,[rcx+0B0]
       mov       [rsp+30],rdx
       mov       rcx,rbx
       lea       rdx,[rsp+38]
       lea       r8,[rsp+20]
       call      qword ptr [7FF84C39E178]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       ret
; Total bytes of code 91
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       sub       rsp,78
       vzeroupper
       vmovaps   [rsp+60],xmm6
       vmovaps   [rsp+50],xmm7
       vmovaps   [rsp+40],xmm8
       vmovaps   [rsp+30],xmm9
       vmovaps   [rsp+20],xmm10
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rsp+8],xmm0
       mov       rax,[rdx+10]
       mov       [rsp+18],rax
       vmovss    xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [r8+8]
       vmovss    xmm3,dword ptr [r8+0C]
       vmovss    xmm4,dword ptr [r8+10]
       vmovss    xmm5,dword ptr [r8+14]
       lea       rax,[rsp+8]
       vmovss    xmm6,dword ptr [rax]
       vmulss    xmm7,xmm6,xmm0
       vmovss    xmm8,dword ptr [rax+4]
       vmulss    xmm9,xmm8,xmm2
       vaddss    xmm7,xmm7,xmm9
       vmulss    xmm6,xmm6,xmm1
       vmulss    xmm8,xmm8,xmm3
       vaddss    xmm6,xmm6,xmm8
       vinsertps xmm6,xmm7,xmm6,1C
       vmovss    xmm7,dword ptr [rax+8]
       vmulss    xmm8,xmm7,xmm0
       vmovss    xmm9,dword ptr [rax+0C]
       vmulss    xmm10,xmm9,xmm2
       vaddss    xmm8,xmm8,xmm10
       vmulss    xmm7,xmm7,xmm1
       vmulss    xmm9,xmm9,xmm3
       vaddss    xmm7,xmm7,xmm9
       vinsertps xmm7,xmm8,xmm7,1C
       vmovss    xmm8,dword ptr [rax+10]
       vmulss    xmm0,xmm8,xmm0
       vmovss    xmm9,dword ptr [rax+14]
       vmulss    xmm2,xmm9,xmm2
       vaddss    xmm0,xmm0,xmm2
       vaddss    xmm0,xmm0,xmm4
       vmulss    xmm1,xmm8,xmm1
       vmulss    xmm2,xmm9,xmm3
       vaddss    xmm1,xmm1,xmm2
       vaddss    xmm1,xmm1,xmm5
       vinsertps xmm0,xmm0,xmm1,1C
       vmovsd    qword ptr [rcx],xmm6
       vmovsd    qword ptr [rcx+8],xmm7
       vmovsd    qword ptr [rcx+10],xmm0
       mov       rax,rcx
       vmovaps   xmm6,[rsp+60]
       vmovaps   xmm7,[rsp+50]
       vmovaps   xmm8,[rsp+40]
       vmovaps   xmm9,[rsp+30]
       vmovaps   xmm10,[rsp+20]
       add       rsp,78
       ret
; Total bytes of code 279
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply4x4()
       push      rbx
       sub       rsp,0A0
       mov       rbx,rdx
       vmovdqu   ymm0,ymmword ptr [rcx+8]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+28]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+48]
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+68]
       vmovdqu   ymmword ptr [rsp+40],ymm0
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FF84C304F00]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 92
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       sub       rsp,58
       vmovaps   [rsp+40],xmm6
       vmovaps   [rsp+30],xmm7
       vmovaps   [rsp+20],xmm8
       vmovaps   [rsp+10],xmm9
       vmovaps   [rsp],xmm10
       vmovups   xmm0,[rdx]
       vmovups   xmm1,[rdx+10]
       vmovups   xmm2,[rdx+20]
       vmovups   xmm3,[rdx+30]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm6,[r8+20]
       vmovups   xmm7,[r8+30]
       vunpckhps xmm8,xmm0,xmm0
       vbroadcastss xmm8,xmm8
       vmovshdup xmm9,xmm0
       vbroadcastss xmm9,xmm9
       vmovaps   xmm10,xmm0
       vbroadcastss xmm10,xmm10
       vmulps    xmm10,xmm10,xmm4
       vfmadd231ps xmm10,xmm9,xmm5
       vfmadd231ps xmm10,xmm8,xmm6
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm10,xmm0,xmm7
       vunpckhps xmm0,xmm1,xmm1
       vbroadcastss xmm0,xmm0
       vmovshdup xmm8,xmm1
       vbroadcastss xmm8,xmm8
       vmovaps   xmm9,xmm1
       vbroadcastss xmm9,xmm9
       vmulps    xmm9,xmm9,xmm4
       vfmadd231ps xmm9,xmm8,xmm5
       vfmadd231ps xmm9,xmm0,xmm6
       vshufps   xmm0,xmm1,xmm1,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm9,xmm0,xmm7
       vunpckhps xmm0,xmm2,xmm2
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm2
       vbroadcastss xmm1,xmm1
       vmovaps   xmm8,xmm2
       vbroadcastss xmm8,xmm8
       vmulps    xmm8,xmm8,xmm4
       vfmadd231ps xmm8,xmm1,xmm5
       vfmadd231ps xmm8,xmm0,xmm6
       vshufps   xmm0,xmm2,xmm2,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm8,xmm0,xmm7
       vunpckhps xmm0,xmm3,xmm3
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm3
       vbroadcastss xmm1,xmm1
       vmovaps   xmm2,xmm3
       vbroadcastss xmm2,xmm2
       vmulps    xmm2,xmm2,xmm4
       vfmadd213ps xmm5,xmm1,xmm2
       vfmadd213ps xmm6,xmm0,xmm5
       vshufps   xmm0,xmm3,xmm3,0FF
       vbroadcastss xmm0,xmm0
       vfmadd213ps xmm7,xmm0,xmm6
       vmovups   [rcx],xmm10
       vmovups   [rcx+10],xmm9
       vmovups   [rcx+20],xmm8
       vmovups   [rcx+30],xmm7
       mov       rax,rcx
       vmovaps   xmm6,[rsp+40]
       vmovaps   xmm7,[rsp+30]
       vmovaps   xmm8,[rsp+20]
       vmovaps   xmm9,[rsp+10]
       vmovaps   xmm10,[rsp]
       add       rsp,58
       ret
; Total bytes of code 355
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Add4x4()
       push      rbx
       sub       rsp,0A0
       mov       rbx,rdx
       vmovdqu   ymm0,ymmword ptr [rcx+8]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+28]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+48]
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+68]
       vmovdqu   ymmword ptr [rsp+40],ymm0
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FF84C334F00]; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 92
```
```assembly
; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       sub       rsp,28
       vmovaps   [rsp+10],xmm6
       vmovaps   [rsp],xmm7
       vmovups   xmm0,[rdx]
       vmovups   xmm1,[rdx+10]
       vmovups   xmm2,[rdx+20]
       vmovups   xmm3,[rdx+30]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm6,[r8+20]
       vmovups   xmm7,[r8+30]
       vaddps    xmm0,xmm0,xmm4
       vaddps    xmm1,xmm1,xmm5
       vaddps    xmm2,xmm2,xmm6
       vaddps    xmm3,xmm3,xmm7
       vmovups   [rcx],xmm0
       vmovups   [rcx+10],xmm1
       vmovups   [rcx+20],xmm2
       vmovups   [rcx+30],xmm3
       mov       rax,rcx
       vmovaps   xmm6,[rsp+10]
       vmovaps   xmm7,[rsp]
       add       rsp,28
       ret
; Total bytes of code 111
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply3x2()
       push      rbx
       sub       rsp,50
       mov       rbx,rdx
       vmovdqu   xmm0,xmmword ptr [rcx+88]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rdx,[rcx+98]
       mov       [rsp+48],rdx
       vmovdqu   xmm0,xmmword ptr [rcx+0A0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       rdx,[rcx+0B0]
       mov       [rsp+30],rdx
       lea       rdx,[rsp+38]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FF84C314FC0]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       ret
; Total bytes of code 88
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       sub       rsp,88
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       vmovaps   [rsp+40],xmm9
       vmovaps   [rsp+30],xmm10
       vmovaps   [rsp+20],xmm11
       vmovaps   [rsp+10],xmm12
       vmovaps   [rsp],xmm13
       vmovss    xmm0,dword ptr [rdx]
       vmovss    xmm1,dword ptr [rdx+4]
       vmovss    xmm2,dword ptr [rdx+8]
       vmovss    xmm3,dword ptr [rdx+0C]
       vmovss    xmm4,dword ptr [rdx+10]
       vmovss    xmm5,dword ptr [rdx+14]
       vmovss    xmm6,dword ptr [r8]
       vmovss    xmm7,dword ptr [r8+4]
       vmovss    xmm8,dword ptr [r8+8]
       vmovss    xmm9,dword ptr [r8+0C]
       vmovss    xmm10,dword ptr [r8+10]
       vmovss    xmm11,dword ptr [r8+14]
       vmulss    xmm12,xmm0,xmm6
       vmulss    xmm13,xmm1,xmm8
       vaddss    xmm12,xmm12,xmm13
       vmulss    xmm0,xmm0,xmm7
       vmulss    xmm1,xmm1,xmm9
       vaddss    xmm0,xmm0,xmm1
       vinsertps xmm0,xmm12,xmm0,1C
       vmulss    xmm1,xmm2,xmm6
       vmulss    xmm12,xmm3,xmm8
       vaddss    xmm1,xmm1,xmm12
       vmulss    xmm2,xmm2,xmm7
       vmulss    xmm3,xmm3,xmm9
       vaddss    xmm2,xmm2,xmm3
       vinsertps xmm1,xmm1,xmm2,1C
       vmulss    xmm2,xmm4,xmm6
       vmulss    xmm3,xmm5,xmm8
       vaddss    xmm2,xmm2,xmm3
       vaddss    xmm2,xmm2,xmm10
       vmulss    xmm3,xmm4,xmm7
       vmulss    xmm4,xmm5,xmm9
       vaddss    xmm3,xmm3,xmm4
       vaddss    xmm3,xmm3,xmm11
       vinsertps xmm2,xmm2,xmm3,1C
       vmovsd    qword ptr [rcx],xmm0
       vmovsd    qword ptr [rcx+8],xmm1
       vmovsd    qword ptr [rcx+10],xmm2
       mov       rax,rcx
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       vmovaps   xmm9,[rsp+40]
       vmovaps   xmm10,[rsp+30]
       vmovaps   xmm11,[rsp+20]
       vmovaps   xmm12,[rsp+10]
       vmovaps   xmm13,[rsp]
       add       rsp,88
       ret
; Total bytes of code 298
```

