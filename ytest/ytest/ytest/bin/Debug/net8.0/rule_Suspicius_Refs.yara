rule susp_refs {
    meta:
        description = "Misc. Cosas que pueden ser sospechosas dentro de un archivo"
        version = "0.1.0"
    strings:
        $s1 = "backdoor" nocase ascii wide
        $s2 = "virus" nocase ascii wide fullword
        $s3 = "hack" nocase ascii wide fullword
        $s4 = "exploit" nocase ascii wide
    condition:
        any of them
}
