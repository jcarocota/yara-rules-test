rule exe2 {
    meta:
        description = "Valida si el archivo es un ejecutable .exe"
    condition:
        uint16(0) == 0x5A4D
}
