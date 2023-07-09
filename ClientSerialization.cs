using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class ClientSerialization
{
    /**| Sauvegarde un nouvel objet |**/
    public static void Save(List<Password> passwordList, string filePath)
    {
        /**| Création et ouverture du fichier |**/
        FileStream file = File.Create(filePath);

        /**| Permet de sérialiser un objet |**/
        BinaryFormatter serealizer = new BinaryFormatter();

        /**| Serealization |**/
        serealizer.Serialize(file, passwordList);

        /**| Fermeture du fichier |**/
        file.Close();
    }

    /**| Ouvre le fichier |**/
    public static List<Password> Open(string filePath)
    {
        List<Password> passwordList = new List<Password>();

        if (File.Exists(filePath))
        {
            /**| Lecteur de fichier |**/
            FileStream fs = null;

            try
            {
                /**| Ouverture |**/
                fs = File.OpenRead(filePath);

                /**| Déserialize le fichier |**/
                BinaryFormatter bf = new BinaryFormatter();

                /**| Récupération du contenu |**/
                passwordList = (List<Password>)bf.Deserialize(fs);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        return passwordList;
    }

    /**| Supprime un password et recréer le fichier |**/
    public static void Delete(Password password, string filePath)
    {
        List<Password> passwordList = new List<Password>();

        if (File.Exists(filePath))
        {
            /**| Lecteur de fichier |**/
            FileStream fileStream = null;

            try
            {
                /**| Ouverture |**/
                fileStream = File.OpenRead(filePath);

                /**| Déserialize le fichier |**/
                BinaryFormatter bf = new BinaryFormatter();

                /**| Récupération du contenu |**/
                passwordList = (List<Password>)bf.Deserialize(fileStream);

                fileStream.Close();

                /**| Index pour la boucle |**/
                int index = 0;
                int indexForRemove = 0;

                /**| On enlève l'objet à l'index ou le password qu'on veux supprimer correspond |**/
                foreach (Password passwordInFile in passwordList)
                {
                    if (password.Name == passwordInFile.Name)
                    {
                        indexForRemove = index;
                    }
                    index += 1;
                }

                /**| On enlève le password de la collection |**/
                passwordList.RemoveAt(indexForRemove);

                /**| On recréer le fichier |**/
                FileStream file = File.Create(filePath);

                /**| On le reserialize |**/
                BinaryFormatter serealizer = new BinaryFormatter();
                serealizer.Serialize(file, passwordList);

                /**| Fermeture du fichier |**/
                file.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

    /**| Modifie un MDP et recréer le fichier |**/
    public static void Edit(Password password, Password aNewPassword, string filePath)
    {
        List<Password> passwordList = new List<Password>();

        if (File.Exists(filePath))
        {
            /**| Lecteur de fichier |**/
            FileStream fileStream = null;

            try
            {
                /**| Ouverture |**/
                fileStream = File.OpenRead(filePath);

                /**| Déserialize le fichier |**/
                BinaryFormatter bf = new BinaryFormatter();

                /**| Récupération du contenu |**/
                passwordList = (List<Password>)bf.Deserialize(fileStream);

                fileStream.Close();

                /**| Index pour la boucle |**/
                int index = 0;
                int indexForRemove = 0;

                /**| On enlève l'objet à l'index ou le password qu'on veux supprimer correspond |**/
                foreach (Password passwordInFile in passwordList)
                {
                    if (password.Name == passwordInFile.Name)
                    {
                        indexForRemove = index;
                    }
                    index += 1;
                }

                /**| On enlève le password de la collection |**/
                passwordList.RemoveAt(indexForRemove);

                /**| On ajoute le mdp a la collection |**/
                passwordList.Add(aNewPassword);

                /**| On recréer le fichier |**/
                FileStream file = File.Create(filePath);

                /**| On le reserialize |**/
                BinaryFormatter serealizer = new BinaryFormatter();
                serealizer.Serialize(file, passwordList);

                /**| Fermeture du fichier |**/
                file.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}