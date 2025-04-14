rule exe2 {
    meta:
        description = "Valida si el archivo es un imagen .jpg"
    condition:
        uint16(0) == 0xD8FF
}
