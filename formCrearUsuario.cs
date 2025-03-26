namespace ProyectoA_CrearUsuarioLocal_CSharp
{
    using System.DirectoryServices;

    public partial class formCrearUsuario : Form
    {
        public formCrearUsuario()
        {
            InitializeComponent();
        }

        private void btCrearUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;
            string descripcion = txtDescripcion.Text;
            string grupoSeguridad = txtGrupo.Text;
            if (String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(contraseña) ||
                String.IsNullOrEmpty(descripcion) || String.IsNullOrEmpty(grupoSeguridad))
            {
                MessageBox.Show($"Debe introducir todos los datos para crear el usuario y " +
                    $"agregarlo como miembro de un grupo de seguridad.", "Faltan datos...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Obtenemos el equipo local (localhost)
                    //DirectoryEntry entradaAD = new("WinNT://localhost,computer");
                    DirectoryEntry entradaAD = new("WinNT://" + Environment.MachineName + ",computer");
                    // Creamos el usuario con una contraseña
                    DirectoryEntry nuevoUsuario = entradaAD.Children.Add(usuario, "user");
                    nuevoUsuario.Invoke("SetPassword", [contraseña]);
                    nuevoUsuario.Invoke("Put", ["Description", descripcion]);
                    nuevoUsuario.CommitChanges();
                    MessageBox.Show($"Cuenta de usuario creada correctamente [{usuario}].", "Usuario creado...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Agregamos el usurio al grupo de seguridad de Administradores
                    try
                    {
                        // Buscamos el grupo de seguridad en el equipo local
                        DirectoryEntry grupoSeguridadAD = entradaAD.Children.Find(grupoSeguridad, "group");
                        if (grupoSeguridadAD != null)
                        {
                            // Si existe el grupo Administradores, agregamos el usuario como miembro
                            grupoSeguridadAD.Invoke("Add", [nuevoUsuario.Path.ToString()]);
                            MessageBox.Show($"Cuenta de usuario [{usuario}] agregada al grupo de [{grupoSeguridad}].",
                                "Usuario miembro de grupo...",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show($"El grupo de seguridad [{grupoSeguridad}] no existe en el equipo o no se ha podido obtener.",
                                "Grupo inexistente...",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al agregar el usuario [{usuario}] al grupo de seguridad [{grupoSeguridad}]: {ex.Message}",
                            "Error al agregar usuario a grupo...",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el usuario {usuario}: {ex.Message}", "Error al crear usuario...",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btDeshabilitarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            if (String.IsNullOrEmpty(usuario))
            {
                MessageBox.Show($"Debe introducir el nombre de un usuario existente para deshabilitarlo.", "Faltan datos...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Obtenemos el equipo local (localhost)
                    DirectoryEntry entradaAD = new("WinNT://" + Environment.MachineName + ",computer");
                    // Buscamos el usuario indicado en el equipo local
                    DirectoryEntry usuarioAD = entradaAD.Children.Find(usuario);
                    // Deshabilitamos el usuario
                    usuarioAD.InvokeSet("AccountDisabled", true);
                    usuarioAD.CommitChanges();
                    MessageBox.Show($"Cuenta de usuario [{usuario}] deshabilitada correctamente.", "Usuario deshabilitado...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al deshabilitar el usuario [{usuario}]: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
