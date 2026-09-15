## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.InheritBench.NextPlain()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFADAD0FC60]; LegacyProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFADABF9CA0]; System.Random+XoshiroImpl.Next()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.Next()
M02_L00:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       rax,r11
       shr       rax,21
       cmp       rax,7FFFFFFF
       je        short M02_L00
       ret
; Total bytes of code 86
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.InheritBench.NextHeir()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFADACFFC60]; LegacyProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.Next(System.Random)
       push      rbx
       sub       rsp,20
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       short M01_L03
       mov       rbx,[rcx+8]
       mov       rcx,offset MT_System.Random+CompatDerivedImpl
       cmp       [rbx],rcx
       jne       short M01_L02
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       call      qword ptr [7FFADACF5E18]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       lea       rcx,[rbx+18]
       call      qword ptr [7FFADACFFC90]; System.Random+CompatPrng.InternalSample()
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       ret
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L01
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,38
       call      qword ptr [7FFB2CCB5B40]
       cmp       esi,80000000
       jne       short M02_L00
       mov       ecx,7FFFFFFF
       jmp       short M02_L01
M02_L00:
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M02_L09
M02_L01:
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,36
M02_L02:
       add       r8d,15
       mov       r9d,r8d
       cmp       r9d,37
       jl        short M02_L03
       lea       r9d,[r8-37]
M02_L03:
       cmp       r9d,38
       jae       near ptr M02_L10
       mov       r8d,r9d
       mov       [rax+r8*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L04
       add       edx,7FFFFFFF
M02_L04:
       mov       ecx,[rax+r8*4+10]
       dec       r10d
       mov       r8d,r9d
       jne       short M02_L02
       mov       ecx,4
M02_L05:
       mov       edx,1
       mov       r8d,1F
M02_L06:
       mov       r10d,edx
       lea       r10,[rax+r10*4+10]
       mov       r9,r10
       mov       r11d,[r9]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L10
       sub       r11d,[rax+r8*4+10]
       mov       [r9],r11d
       test      r11d,r11d
       jge       short M02_L07
       add       r11d,7FFFFFFF
       mov       [r10],r11d
M02_L07:
       inc       edx
       cmp       edx,38
       jge       short M02_L08
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L06
       add       r8d,0FFFFFFC9
       jmp       short M02_L06
M02_L08:
       dec       ecx
       jne       short M02_L05
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB2CCA7FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       mov       ecx,esi
       neg       ecx
       jns       near ptr M02_L01
       call      qword ptr [7FFB2CCB9E18]
       int       3
M02_L10:
       call      qword ptr [7FFB2CCA7FC0]
       int       3
; Total bytes of code 281
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M03_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M03_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.InheritBench.DoublePlain()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFADACFFD50]; LegacyProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.NextDouble(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFADABE9CD8]; System.Random+XoshiroImpl.NextDouble()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.NextDouble()
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       shr       r11,0B
       vxorps    xmm0,xmm0,xmm0
       mov       rcx,r11
       shr       rcx,1
       mov       eax,r11d
       and       eax,1
       or        rax,rcx
       test      r11,r11
       cmovns    rax,r11
       vcvtsi2sd xmm0,xmm0,rax
       jns       short M02_L00
       vaddsd    xmm0,xmm0,xmm0
M02_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFADAA095F8]
       ret
; Total bytes of code 120
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.InheritBench.DoubleHeir()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFADAD1FD50]; LegacyProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.NextDouble(System.Random)
       push      rbx
       sub       rsp,20
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       near ptr M01_L06
       mov       rbx,[rcx+8]
       mov       rcx,offset MT_System.Random+CompatDerivedImpl
       cmp       [rbx],rcx
       jne       near ptr M01_L05
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       call      qword ptr [7FFADAD15E18]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       short M01_L04
       mov       rbx,[rcx+8]
       mov       rcx,offset MT_System.Random+CompatDerivedImpl
       cmp       [rbx],rcx
       jne       short M01_L03
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L01
       call      qword ptr [7FFADAD15E18]; System.Random+CompatPrng.Initialize(Int32)
M01_L01:
       lea       rcx,[rbx+18]
       call      qword ptr [7FFADAD1FDC8]; System.Random+CompatPrng.InternalSample()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FFADAA29798]
M01_L02:
       add       rsp,20
       pop       rbx
       ret
M01_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L02
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       short M01_L02
M01_L05:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L02
M01_L06:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L02
; Total bytes of code 209
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,38
       call      qword ptr [7FFB2CCB5B40]
       cmp       esi,80000000
       jne       short M02_L00
       mov       ecx,7FFFFFFF
       jmp       short M02_L01
M02_L00:
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M02_L09
M02_L01:
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,36
M02_L02:
       add       r8d,15
       mov       r9d,r8d
       cmp       r9d,37
       jl        short M02_L03
       lea       r9d,[r8-37]
M02_L03:
       cmp       r9d,38
       jae       near ptr M02_L10
       mov       r8d,r9d
       mov       [rax+r8*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L04
       add       edx,7FFFFFFF
M02_L04:
       mov       ecx,[rax+r8*4+10]
       dec       r10d
       mov       r8d,r9d
       jne       short M02_L02
       mov       ecx,4
M02_L05:
       mov       edx,1
       mov       r8d,1F
M02_L06:
       mov       r10d,edx
       lea       r10,[rax+r10*4+10]
       mov       r9,r10
       mov       r11d,[r9]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L10
       sub       r11d,[rax+r8*4+10]
       mov       [r9],r11d
       test      r11d,r11d
       jge       short M02_L07
       add       r11d,7FFFFFFF
       mov       [r10],r11d
M02_L07:
       inc       edx
       cmp       edx,38
       jge       short M02_L08
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L06
       add       r8d,0FFFFFFC9
       jmp       short M02_L06
M02_L08:
       dec       ecx
       jne       short M02_L05
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB2CCA7FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       mov       ecx,esi
       neg       ecx
       jns       near ptr M02_L01
       call      qword ptr [7FFB2CCB9E18]
       int       3
M02_L10:
       call      qword ptr [7FFB2CCA7FC0]
       int       3
; Total bytes of code 281
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M03_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M03_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.InheritBench.BytesPlain()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFADACFFD38]; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L03
       test      rdx,rdx
       je        short M01_L01
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L02
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       [rsp+28],rax
       mov       [rsp+30],edx
       lea       rdx,[rsp+28]
       call      qword ptr [7FFADABE97E8]; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
M01_L00:
       nop
       add       rsp,38
       ret
M01_L01:
       mov       ecx,56
       call      qword ptr [7FFADA99FD38]
       int       3
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 119
```
```assembly
; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       mov       rbp,[rcx+10]
       mov       r14,[rcx+18]
       mov       r15,[rcx+20]
       cmp       esi,8
       jl        short M02_L01
M02_L00:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       cmp       esi,8
       jl        short M02_L03
       mov       [rbx],rax
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       add       rbx,8
       add       esi,0FFFFFFF8
       cmp       esi,8
       jge       short M02_L00
M02_L01:
       test      esi,esi
       jne       short M02_L04
M02_L02:
       mov       [rcx+8],rdi
       mov       [rcx+10],rbp
       mov       [rcx+18],r14
       mov       [rcx+20],r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       ecx,28
       call      qword ptr [7FFADA99F348]
       int       3
M02_L04:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rsp+20],rax
       xor       eax,eax
       cmp       eax,esi
       jge       short M02_L06
M02_L05:
       lea       rdx,[rsp+20]
       movzx     edx,byte ptr [rdx+rax]
       mov       [rbx+rax],dl
       inc       eax
       cmp       eax,esi
       jl        short M02_L05
M02_L06:
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       jmp       short M02_L02
; Total bytes of code 213
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.InheritBench.BytesHeir()
       mov       rdx,rcx
       mov       rcx,[rdx+10]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFADACFFC48]; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       short M01_L05
       test      rbx,rbx
       je        short M01_L03
       mov       rsi,[rcx+8]
       mov       rcx,offset MT_System.Random+CompatDerivedImpl
       cmp       [rsi],rcx
       jne       short M01_L04
       lea       rcx,[rsi+18]
       mov       edx,[rsi+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       call      qword ptr [7FFADACF5E00]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       add       rsi,18
       lea       rdi,[rbx+10]
       mov       ebx,[rbx+8]
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M01_L02
M01_L01:
       mov       rcx,rsi
       call      qword ptr [7FFADACFFC90]; System.Random+CompatPrng.InternalSample()
       mov       [rdi+rbp],al
       inc       ebp
       cmp       ebp,ebx
       jl        short M01_L01
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,56
       call      qword ptr [7FFADA99FD38]
       int       3
M01_L04:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L02
M01_L05:
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L02
; Total bytes of code 158
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,38
       call      qword ptr [7FFB2CCB5B40]
       cmp       esi,80000000
       jne       short M02_L00
       mov       ecx,7FFFFFFF
       jmp       short M02_L01
M02_L00:
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M02_L09
M02_L01:
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,36
M02_L02:
       add       r8d,15
       mov       r9d,r8d
       cmp       r9d,37
       jl        short M02_L03
       lea       r9d,[r8-37]
M02_L03:
       cmp       r9d,38
       jae       near ptr M02_L10
       mov       r8d,r9d
       mov       [rax+r8*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L04
       add       edx,7FFFFFFF
M02_L04:
       mov       ecx,[rax+r8*4+10]
       dec       r10d
       mov       r8d,r9d
       jne       short M02_L02
       mov       ecx,4
M02_L05:
       mov       edx,1
       mov       r8d,1F
M02_L06:
       mov       r10d,edx
       lea       r10,[rax+r10*4+10]
       mov       r9,r10
       mov       r11d,[r9]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L10
       sub       r11d,[rax+r8*4+10]
       mov       [r9],r11d
       test      r11d,r11d
       jge       short M02_L07
       add       r11d,7FFFFFFF
       mov       [r10],r11d
M02_L07:
       inc       edx
       cmp       edx,38
       jge       short M02_L08
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L06
       add       r8d,0FFFFFFC9
       jmp       short M02_L06
M02_L08:
       dec       ecx
       jne       short M02_L05
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB2CCA7FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       mov       ecx,esi
       neg       ecx
       jns       near ptr M02_L01
       call      qword ptr [7FFB2CCB9E18]
       int       3
M02_L10:
       call      qword ptr [7FFB2CCA7FC0]
       int       3
; Total bytes of code 281
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M03_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M03_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.InheritBench.NextPlain()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFACEB6CE58]; LegacyProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFACE94F730]; System.Random+XoshiroImpl.Next()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.Next()
M02_L00:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       lea       r9,[rdx+rdx*4]
       rol       r9,7
       lea       r9,[r9+r9*8]
       mov       r11,rdx
       shl       r11,11
       xor       r8,rax
       xor       r10,rdx
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r11
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       rax,r9
       shr       rax,21
       cmp       rax,7FFFFFFF
       je        short M02_L00
       ret
; Total bytes of code 86
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.InheritBench.NextHeir()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFACEB6CE58]; LegacyProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.Next(System.Random)
       push      rbx
       sub       rsp,20
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       short M01_L03
       mov       rcx,[rcx+8]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       cmp       [rbx],rcx
       jne       short M01_L02
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       call      qword ptr [7FFACE95EA90]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       lea       rcx,[rbx+18]
       call      qword ptr [7FFACE95EAD8]; System.Random+CompatPrng.InternalSample()
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       ret
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L01
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L01
; Total bytes of code 105
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,38
       call      qword ptr [7FFB248EEA60]
       cmp       esi,80000000
       je        short M02_L02
       test      esi,esi
       jl        short M02_L01
M02_L00:
       jmp       short M02_L03
M02_L01:
       neg       esi
       js        near ptr M02_L11
       jmp       short M02_L00
M02_L02:
       mov       esi,7FFFFFFF
M02_L03:
       mov       ecx,esi
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,1
M02_L04:
       add       r8d,15
       cmp       r8d,37
       jl        short M02_L05
       add       r8d,0FFFFFFC9
M02_L05:
       cmp       r8d,38
       jae       near ptr M02_L12
       mov       r9d,r8d
       mov       [rax+r9*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L06
       add       edx,7FFFFFFF
M02_L06:
       mov       ecx,[rax+r9*4+10]
       inc       r10d
       cmp       r10d,37
       jl        short M02_L04
       mov       ecx,1
M02_L07:
       mov       edx,1
M02_L08:
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L09
       add       r8d,0FFFFFFC9
M02_L09:
       mov       r10d,edx
       lea       r10,[rax+r10*4+10]
       mov       r9d,[r10]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L12
       sub       r9d,[rax+r8*4+10]
       mov       [r10],r9d
       test      r9d,r9d
       jge       short M02_L10
       mov       r8d,edx
       lea       r8,[rax+r8*4+10]
       add       r9d,7FFFFFFF
       mov       [r8],r9d
M02_L10:
       inc       edx
       cmp       edx,38
       jl        short M02_L08
       inc       ecx
       cmp       ecx,5
       jl        short M02_L07
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB248E3D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L11:
       call      qword ptr [7FFB248F25A0]
       int       3
M02_L12:
       call      qword ptr [7FFB248E3D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M03_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M03_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.InheritBench.DoublePlain()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFACEB4CC00]; LegacyProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.NextDouble(System.Random)
       sub       rsp,28
       vzeroupper
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFACE92F768]; System.Random+XoshiroImpl.NextDouble()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L00
; Total bytes of code 77
```
```assembly
; System.Random+XoshiroImpl.NextDouble()
       vzeroupper
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       lea       r9,[rdx+rdx*4]
       rol       r9,7
       lea       r9,[r9+r9*8]
       mov       r11,rdx
       shl       r11,11
       xor       r8,rax
       xor       r10,rdx
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r11
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       shr       r9,0B
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,r9
       test      r9,r9
       jge       short M02_L00
       vaddsd    xmm0,xmm0,qword ptr [7FFACE777ED0]
M02_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFACE777ED8]
       ret
; Total bytes of code 108
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.InheritBench.DoubleHeir()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFACEB7CC00]; LegacyProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.NextDouble(System.Random)
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       near ptr M01_L06
       mov       rcx,[rcx+8]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       cmp       [rbx],rcx
       jne       near ptr M01_L05
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       call      qword ptr [7FFACE96EA90]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       short M01_L04
       mov       rcx,[rcx+8]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       cmp       [rbx],rcx
       jne       short M01_L03
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L01
       call      qword ptr [7FFACE96EA90]; System.Random+CompatPrng.Initialize(Int32)
M01_L01:
       lea       rcx,[rbx+18]
       call      qword ptr [7FFACE96EAD8]; System.Random+CompatPrng.InternalSample()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FFACE7A8000]
M01_L02:
       add       rsp,20
       pop       rbx
       ret
M01_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L02
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       short M01_L02
M01_L05:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L02
M01_L06:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L02
; Total bytes of code 218
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,38
       call      qword ptr [7FFB248EEA60]
       cmp       esi,80000000
       je        short M02_L02
       test      esi,esi
       jl        short M02_L01
M02_L00:
       jmp       short M02_L03
M02_L01:
       neg       esi
       js        near ptr M02_L11
       jmp       short M02_L00
M02_L02:
       mov       esi,7FFFFFFF
M02_L03:
       mov       ecx,esi
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,1
M02_L04:
       add       r8d,15
       cmp       r8d,37
       jl        short M02_L05
       add       r8d,0FFFFFFC9
M02_L05:
       cmp       r8d,38
       jae       near ptr M02_L12
       mov       r9d,r8d
       mov       [rax+r9*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L06
       add       edx,7FFFFFFF
M02_L06:
       mov       ecx,[rax+r9*4+10]
       inc       r10d
       cmp       r10d,37
       jl        short M02_L04
       mov       ecx,1
M02_L07:
       mov       edx,1
M02_L08:
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L09
       add       r8d,0FFFFFFC9
M02_L09:
       mov       r10d,edx
       lea       r10,[rax+r10*4+10]
       mov       r9d,[r10]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L12
       sub       r9d,[rax+r8*4+10]
       mov       [r10],r9d
       test      r9d,r9d
       jge       short M02_L10
       mov       r8d,edx
       lea       r8,[rax+r8*4+10]
       add       r9d,7FFFFFFF
       mov       [r8],r9d
M02_L10:
       inc       edx
       cmp       edx,38
       jl        short M02_L08
       inc       ecx
       cmp       ecx,5
       jl        short M02_L07
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB248E3D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L11:
       call      qword ptr [7FFB248F25A0]
       int       3
M02_L12:
       call      qword ptr [7FFB248E3D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M03_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M03_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.InheritBench.BytesPlain()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFACEB5CE88]; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L03
       test      rdx,rdx
       je        short M01_L01
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L02
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       [rsp+28],rax
       mov       [rsp+30],edx
       lea       rdx,[rsp+28]
       call      qword ptr [7FFACE93F350]; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
M01_L00:
       nop
       add       rsp,38
       ret
M01_L01:
       mov       ecx,5C
       call      qword ptr [7FFACE8EED00]
       int       3
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 119
```
```assembly
; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       mov       rbp,[rcx+10]
       mov       r14,[rcx+18]
       mov       r15,[rcx+20]
       cmp       esi,8
       jl        short M02_L01
       nop       dword ptr [rax+rax]
M02_L00:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rbx],rax
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       cmp       esi,8
       jb        short M02_L04
       add       rbx,8
       add       esi,0FFFFFFF8
       cmp       esi,8
       jge       short M02_L00
M02_L01:
       test      esi,esi
       jne       short M02_L03
M02_L02:
       mov       [rcx+8],rdi
       mov       [rcx+10],rbp
       mov       [rcx+18],r14
       mov       [rcx+20],r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rsp+20],rax
       lea       r13,[rsp+20]
       xor       r12d,r12d
       jmp       short M02_L06
M02_L04:
       call      qword ptr [7FFACE8EE9D0]
       int       3
M02_L05:
       mov       eax,r12d
       movsxd    rdx,r12d
       movzx     edx,byte ptr [rdx+r13]
       mov       [rbx+rax],dl
       inc       r12d
M02_L06:
       cmp       r12d,esi
       jl        short M02_L05
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       jmp       short M02_L02
; Total bytes of code 229
```

## .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.InheritBench.BytesHeir()
       mov       rdx,rcx
       mov       rcx,[rdx+10]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFACEB7CE88]; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       short M01_L05
       test      rbx,rbx
       je        short M01_L03
       mov       rsi,[rcx+8]
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       cmp       [rsi],rcx
       jne       short M01_L04
       lea       rcx,[rsi+18]
       mov       edx,[rsi+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       call      qword ptr [7FFACE96E850]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       add       rsi,18
       lea       rdi,[rbx+10]
       mov       ebx,[rbx+8]
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M01_L02
M01_L01:
       mov       r14d,ebp
       mov       rcx,rsi
       call      qword ptr [7FFACE96E898]; System.Random+CompatPrng.InternalSample()
       mov       [rdi+r14],al
       inc       ebp
       cmp       ebp,ebx
       jl        short M01_L01
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       ecx,5C
       call      qword ptr [7FFACE90ED00]
       int       3
M01_L04:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L02
M01_L05:
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L02
; Total bytes of code 166
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,38
       call      qword ptr [7FFB248EEA60]
       cmp       esi,80000000
       je        short M02_L02
       test      esi,esi
       jl        short M02_L01
M02_L00:
       jmp       short M02_L03
M02_L01:
       neg       esi
       js        near ptr M02_L11
       jmp       short M02_L00
M02_L02:
       mov       esi,7FFFFFFF
M02_L03:
       mov       ecx,esi
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,1
M02_L04:
       add       r8d,15
       cmp       r8d,37
       jl        short M02_L05
       add       r8d,0FFFFFFC9
M02_L05:
       cmp       r8d,38
       jae       near ptr M02_L12
       mov       r9d,r8d
       mov       [rax+r9*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L06
       add       edx,7FFFFFFF
M02_L06:
       mov       ecx,[rax+r9*4+10]
       inc       r10d
       cmp       r10d,37
       jl        short M02_L04
       mov       ecx,1
M02_L07:
       mov       edx,1
M02_L08:
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L09
       add       r8d,0FFFFFFC9
M02_L09:
       mov       r10d,edx
       lea       r10,[rax+r10*4+10]
       mov       r9d,[r10]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L12
       sub       r9d,[rax+r8*4+10]
       mov       [r10],r9d
       test      r9d,r9d
       jge       short M02_L10
       mov       r8d,edx
       lea       r8,[rax+r8*4+10]
       add       r9d,7FFFFFFF
       mov       [r8],r9d
M02_L10:
       inc       edx
       cmp       edx,38
       jl        short M02_L08
       inc       ecx
       cmp       ecx,5
       jl        short M02_L07
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB248E3D38]; CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L11:
       call      qword ptr [7FFB248F25A0]
       int       3
M02_L12:
       call      qword ptr [7FFB248E3D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M03_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M03_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.InheritBench.NextPlain()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFACF05EE38]; LegacyProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFACEF45B58]; System.Random+XoshiroImpl.Next()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.Next()
M02_L00:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       rax,r11
       shr       rax,21
       cmp       rax,7FFFFFFF
       je        short M02_L00
       ret
; Total bytes of code 86
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.InheritBench.NextHeir()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFACF06EE38]; LegacyProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.Next(System.Random)
       push      rbx
       sub       rsp,20
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       short M01_L03
       mov       rbx,[rcx+8]
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       cmp       [rbx],rcx
       jne       short M01_L02
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       call      qword ptr [7FFACF064E70]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       lea       rcx,[rbx+18]
       call      qword ptr [7FFACF06EE68]; System.Random+CompatPrng.InternalSample()
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       ret
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L01
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L01
; Total bytes of code 102
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,38
       call      qword ptr [7FFB248DE0D8]
       cmp       esi,80000000
       jne       short M02_L00
       mov       ecx,7FFFFFFF
       jmp       short M02_L01
M02_L00:
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M02_L09
M02_L01:
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,36
M02_L02:
       add       r8d,15
       mov       r9d,r8d
       cmp       r9d,37
       jl        short M02_L03
       lea       r9d,[r8-37]
M02_L03:
       cmp       r9d,38
       jae       near ptr M02_L10
       mov       r8d,r9d
       mov       [rax+r8*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L04
       add       edx,7FFFFFFF
M02_L04:
       mov       ecx,[rax+r8*4+10]
       dec       r10d
       mov       r8d,r9d
       jne       short M02_L02
       mov       ecx,4
M02_L05:
       mov       edx,1
M02_L06:
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L07
       add       r8d,0FFFFFFC9
M02_L07:
       lea       r10,[rax+rdx*4+10]
       mov       r9d,[r10]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L10
       sub       r9d,[rax+r8*4+10]
       mov       [r10],r9d
       test      r9d,r9d
       jge       short M02_L08
       lea       r8,[rax+rdx*4+10]
       add       r9d,7FFFFFFF
       mov       [r8],r9d
M02_L08:
       inc       edx
       cmp       edx,38
       jl        short M02_L06
       dec       ecx
       jne       short M02_L05
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB248D10F8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       mov       ecx,esi
       neg       ecx
       jns       near ptr M02_L01
       call      qword ptr [7FFB248E21C0]
       int       3
M02_L10:
       call      qword ptr [7FFB248D10E0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M03_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M03_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.InheritBench.DoublePlain()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFACF07EE38]; LegacyProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.NextDouble(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFACEF65B90]; System.Random+XoshiroImpl.NextDouble()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.NextDouble()
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       shr       r11,0B
       vxorps    xmm0,xmm0,xmm0
       mov       rax,r11
       shr       rax,1
       mov       ecx,r11d
       and       ecx,1
       or        rcx,rax
       test      r11,r11
       cmovns    rcx,r11
       vcvtsi2sd xmm0,xmm0,rcx
       jns       short M02_L00
       vaddsd    xmm0,xmm0,xmm0
M02_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFACED79258]
       ret
; Total bytes of code 120
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.InheritBench.DoubleHeir()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFACF04EE38]; LegacyProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; LegacyProof.Subjects.NextDouble(System.Random)
       push      rbx
       sub       rsp,20
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       near ptr M01_L06
       mov       rbx,[rcx+8]
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       cmp       [rbx],rcx
       jne       near ptr M01_L05
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       call      qword ptr [7FFACF044E70]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       short M01_L04
       mov       rbx,[rcx+8]
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       cmp       [rbx],rcx
       jne       short M01_L03
       lea       rcx,[rbx+18]
       mov       edx,[rbx+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L01
       call      qword ptr [7FFACF044E70]; System.Random+CompatPrng.Initialize(Int32)
M01_L01:
       lea       rcx,[rbx+18]
       call      qword ptr [7FFACF04EEB0]; System.Random+CompatPrng.InternalSample()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FFACED49388]
M01_L02:
       add       rsp,20
       pop       rbx
       ret
M01_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L02
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       short M01_L02
M01_L05:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L02
M01_L06:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L02
; Total bytes of code 209
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,38
       call      qword ptr [7FFB248DE0D8]
       cmp       esi,80000000
       jne       short M02_L00
       mov       ecx,7FFFFFFF
       jmp       short M02_L01
M02_L00:
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M02_L09
M02_L01:
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,36
M02_L02:
       add       r8d,15
       mov       r9d,r8d
       cmp       r9d,37
       jl        short M02_L03
       lea       r9d,[r8-37]
M02_L03:
       cmp       r9d,38
       jae       near ptr M02_L10
       mov       r8d,r9d
       mov       [rax+r8*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L04
       add       edx,7FFFFFFF
M02_L04:
       mov       ecx,[rax+r8*4+10]
       dec       r10d
       mov       r8d,r9d
       jne       short M02_L02
       mov       ecx,4
M02_L05:
       mov       edx,1
M02_L06:
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L07
       add       r8d,0FFFFFFC9
M02_L07:
       lea       r10,[rax+rdx*4+10]
       mov       r9d,[r10]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L10
       sub       r9d,[rax+r8*4+10]
       mov       [r10],r9d
       test      r9d,r9d
       jge       short M02_L08
       lea       r8,[rax+rdx*4+10]
       add       r9d,7FFFFFFF
       mov       [r8],r9d
M02_L08:
       inc       edx
       cmp       edx,38
       jl        short M02_L06
       dec       ecx
       jne       short M02_L05
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB248D10F8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       mov       ecx,esi
       neg       ecx
       jns       near ptr M02_L01
       call      qword ptr [7FFB248E21C0]
       int       3
M02_L10:
       call      qword ptr [7FFB248D10E0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M03_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M03_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.InheritBench.BytesPlain()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFACF03ED48]; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L03
       test      rdx,rdx
       je        short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       [rsp+28],rax
       mov       [rsp+30],edx
       lea       rdx,[rsp+28]
       call      qword ptr [7FFACEF256A0]; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
M01_L00:
       nop
       add       rsp,38
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       ecx,58
       call      qword ptr [7FFACEC8FB28]
       int       3
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 119
```
```assembly
; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       mov       rbp,[rcx+10]
       mov       r14,[rcx+18]
       mov       r15,[rcx+20]
       cmp       esi,8
       jl        short M02_L01
M02_L00:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rbx],rax
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       cmp       esi,8
       jb        short M02_L03
       add       rbx,8
       add       esi,0FFFFFFF8
       cmp       esi,8
       jge       short M02_L00
M02_L01:
       test      esi,esi
       jne       short M02_L04
M02_L02:
       mov       [rcx+8],rdi
       mov       [rcx+10],rbp
       mov       [rcx+18],r14
       mov       [rcx+20],r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      qword ptr [7FFACEE97798]
       int       3
M02_L04:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rsp+20],rax
       xor       eax,eax
M02_L05:
       cmp       eax,esi
       jge       short M02_L06
       lea       rdx,[rsp+20]
       movsxd    r8,eax
       movzx     edx,byte ptr [rdx+r8]
       mov       [rbx+rax],dl
       inc       eax
       jmp       short M02_L05
M02_L06:
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       jmp       short M02_L02
; Total bytes of code 210
```

## .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.InheritBench.BytesHeir()
       mov       rdx,rcx
       mov       rcx,[rdx+10]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFACF07EE20]; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; LegacyProof.Subjects.NextBytes(System.Random, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rdx,offset MT_LegacyProof.Types.EmptyRandom
       cmp       [rcx],rdx
       jne       short M01_L05
       test      rbx,rbx
       je        short M01_L04
       mov       rsi,[rcx+8]
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       cmp       [rsi],rcx
       jne       short M01_L03
       lea       rcx,[rsi+18]
       mov       edx,[rsi+10]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       call      qword ptr [7FFACF074E58]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       add       rsi,18
       lea       rdi,[rbx+10]
       mov       ebx,[rbx+8]
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M01_L02
M01_L01:
       mov       rcx,rsi
       call      qword ptr [7FFACF07EE68]; System.Random+CompatPrng.InternalSample()
       mov       [rdi+rbp],al
       inc       ebp
       cmp       ebp,ebx
       jl        short M01_L01
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L02
M01_L04:
       mov       ecx,58
       call      qword ptr [7FFACECCFB28]
       int       3
M01_L05:
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L02
; Total bytes of code 158
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       ecx,38
       call      qword ptr [7FFB248DE0D8]
       cmp       esi,80000000
       jne       short M02_L00
       mov       ecx,7FFFFFFF
       jmp       short M02_L01
M02_L00:
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M02_L09
M02_L01:
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,36
M02_L02:
       add       r8d,15
       mov       r9d,r8d
       cmp       r9d,37
       jl        short M02_L03
       lea       r9d,[r8-37]
M02_L03:
       cmp       r9d,38
       jae       near ptr M02_L10
       mov       r8d,r9d
       mov       [rax+r8*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L04
       add       edx,7FFFFFFF
M02_L04:
       mov       ecx,[rax+r8*4+10]
       dec       r10d
       mov       r8d,r9d
       jne       short M02_L02
       mov       ecx,4
M02_L05:
       mov       edx,1
M02_L06:
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L07
       add       r8d,0FFFFFFC9
M02_L07:
       lea       r10,[rax+rdx*4+10]
       mov       r9d,[r10]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L10
       sub       r9d,[rax+r8*4+10]
       mov       [r10],r9d
       test      r9d,r9d
       jge       short M02_L08
       lea       r8,[rax+rdx*4+10]
       add       r9d,7FFFFFFF
       mov       [r8],r9d
M02_L08:
       inc       edx
       cmp       edx,38
       jl        short M02_L06
       dec       ecx
       jne       short M02_L05
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB248D10F8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L09:
       mov       ecx,esi
       neg       ecx
       jns       near ptr M02_L01
       call      qword ptr [7FFB248E21C0]
       int       3
M02_L10:
       call      qword ptr [7FFB248D10E0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M03_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M03_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

