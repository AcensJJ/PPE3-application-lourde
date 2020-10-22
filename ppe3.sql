-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 13 mars 2019 à 07:42
-- Version du serveur :  5.7.21
-- Version de PHP :  5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ppe3`
--

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`id`, `libelle`) VALUES
(1, 'T-shirt'),
(2, 'Pull'),
(3, 'Veste'),
(4, 'Pantalon'),
(5, 'Short');

-- --------------------------------------------------------

--
-- Structure de la table `commande_order`
--

DROP TABLE IF EXISTS `commande_order`;
CREATE TABLE IF NOT EXISTS `commande_order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `identity_id` int(11) NOT NULL,
  `livraison_id` int(11) NOT NULL,
  `payment_order_id` int(11) NOT NULL,
  `reference` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `commentaire` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `status` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_CC414C5BFF3ED4A8` (`identity_id`),
  UNIQUE KEY `UNIQ_CC414C5B8E54FB25` (`livraison_id`),
  UNIQUE KEY `UNIQ_CC414C5BCD592F50` (`payment_order_id`),
  KEY `IDX_CC414C5BA76ED395` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `commande_order`
--

INSERT INTO `commande_order` (`id`, `user_id`, `identity_id`, `livraison_id`, `payment_order_id`, `reference`, `commentaire`, `status`, `date`) VALUES
(1, 1, 1, 1, 1, 'COM_BFF2462926', NULL, 'En attente', '2019-03-13 07:42:06'),
(2, 1, 2, 2, 2, 'COM_BFF2462926', NULL, 'En attente', '2019-03-13 07:42:06'),
(3, 1, 3, 3, 3, 'COM_BFF2462926', NULL, 'En attente', '2019-03-13 07:42:06');

-- --------------------------------------------------------

--
-- Structure de la table `commande_order_produit`
--

DROP TABLE IF EXISTS `commande_order_produit`;
CREATE TABLE IF NOT EXISTS `commande_order_produit` (
  `commande_order_id` int(11) NOT NULL,
  `produit_id` int(11) NOT NULL,
  PRIMARY KEY (`commande_order_id`,`produit_id`),
  KEY `IDX_3EEB21D45BBF75A2` (`commande_order_id`),
  KEY `IDX_3EEB21D4F347EFB` (`produit_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `commande_order_produit`
--

INSERT INTO `commande_order_produit` (`commande_order_id`, `produit_id`) VALUES
(1, 14),
(1, 15),
(2, 14),
(2, 15),
(3, 14),
(3, 15);

-- --------------------------------------------------------

--
-- Structure de la table `fos_user`
--

DROP TABLE IF EXISTS `fos_user`;
CREATE TABLE IF NOT EXISTS `fos_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(180) COLLATE utf8mb4_unicode_ci NOT NULL,
  `username_canonical` varchar(180) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(180) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_canonical` varchar(180) COLLATE utf8mb4_unicode_ci NOT NULL,
  `enabled` tinyint(1) NOT NULL,
  `salt` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `last_login` datetime DEFAULT NULL,
  `confirmation_token` varchar(180) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `password_requested_at` datetime DEFAULT NULL,
  `roles` longtext COLLATE utf8mb4_unicode_ci NOT NULL COMMENT '(DC2Type:array)',
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_957A647992FC23A8` (`username_canonical`),
  UNIQUE KEY `UNIQ_957A6479A0D96FBF` (`email_canonical`),
  UNIQUE KEY `UNIQ_957A6479C05FB297` (`confirmation_token`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `fos_user`
--

INSERT INTO `fos_user` (`id`, `username`, `username_canonical`, `email`, `email_canonical`, `enabled`, `salt`, `password`, `last_login`, `confirmation_token`, `password_requested_at`, `roles`) VALUES
(1, 'admin', 'admin', 'admin@admin.fr', 'admin@admin.fr', 1, NULL, '$2y$13$gTMCg6wVdIY5YxVcb.69/.vXBkVV5zUmxOL4T5766ueMzAL1icAEe', NULL, NULL, NULL, 'a:1:{i:0;s:10:\"ROLE_ADMIN\";}'),
(2, 'user', 'user', 'user@user.fr', 'user@user.fr', 1, NULL, '$2y$13$UEDfdgnGjxIfHe8A8m.E5eBWu4opmr47iS1AAJtk84mZo4FJKcESS', NULL, NULL, NULL, 'a:0:{}');

-- --------------------------------------------------------

--
-- Structure de la table `identity_order`
--

DROP TABLE IF EXISTS `identity_order`;
CREATE TABLE IF NOT EXISTS `identity_order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenom` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `num_tel` int(11) NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `identity_order`
--

INSERT INTO `identity_order` (`id`, `nom`, `prenom`, `num_tel`, `email`) VALUES
(1, 'aaa', 'AAA', 0, 'aaa@aaa.fr'),
(2, 'aaa', 'AAA', 0, 'aaa@aaa.fr'),
(3, 'aaa', 'AAA', 0, 'aaa@aaa.fr');

-- --------------------------------------------------------

--
-- Structure de la table `identity_user`
--

DROP TABLE IF EXISTS `identity_user`;
CREATE TABLE IF NOT EXISTS `identity_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `nom` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenom` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `num_tel` int(11) NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_39E1FCDA76ED395` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `livraison_order`
--

DROP TABLE IF EXISTS `livraison_order`;
CREATE TABLE IF NOT EXISTS `livraison_order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `adresse` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `code_postal` int(11) NOT NULL,
  `ville` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pays` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `livraison_order`
--

INSERT INTO `livraison_order` (`id`, `adresse`, `code_postal`, `ville`, `pays`) VALUES
(1, '00 rue test', 66000, 'Perpignan', 'France'),
(2, '00 rue test', 66000, 'Perpignan', 'France'),
(3, '00 rue test', 66000, 'Perpignan', 'France');

-- --------------------------------------------------------

--
-- Structure de la table `livraison_user`
--

DROP TABLE IF EXISTS `livraison_user`;
CREATE TABLE IF NOT EXISTS `livraison_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `adresse` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `code_postal` int(11) NOT NULL,
  `ville` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pays` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_2662B5F8A76ED395` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `mode_livraison`
--

DROP TABLE IF EXISTS `mode_livraison`;
CREATE TABLE IF NOT EXISTS `mode_livraison` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `mode` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prix` double NOT NULL,
  `description` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `mode_livraison`
--

INSERT INTO `mode_livraison` (`id`, `mode`, `prix`, `description`) VALUES
(1, 'standard', 0, 'Livraison sous 1 semaine'),
(2, 'fast', 10, 'Livraison rapide sous 2 semaine');

-- --------------------------------------------------------

--
-- Structure de la table `mode_payment`
--

DROP TABLE IF EXISTS `mode_payment`;
CREATE TABLE IF NOT EXISTS `mode_payment` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `image` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `mode_payment`
--

INSERT INTO `mode_payment` (`id`, `libelle`, `image`) VALUES
(1, 'PayPal', 'http://www.websuccessstories.com/wp-content/uploads/2015/03/Paypal.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `panier`
--

DROP TABLE IF EXISTS `panier`;
CREATE TABLE IF NOT EXISTS `panier` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_24CC0DF2A76ED395` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `panier`
--

INSERT INTO `panier` (`id`, `user_id`) VALUES
(1, 1),
(2, 2);

-- --------------------------------------------------------

--
-- Structure de la table `panier_produit`
--

DROP TABLE IF EXISTS `panier_produit`;
CREATE TABLE IF NOT EXISTS `panier_produit` (
  `panier_id` int(11) NOT NULL,
  `produit_id` int(11) NOT NULL,
  PRIMARY KEY (`panier_id`,`produit_id`),
  KEY `IDX_D31F28A6F77D927C` (`panier_id`),
  KEY `IDX_D31F28A6F347EFB` (`produit_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `payment_order`
--

DROP TABLE IF EXISTS `payment_order`;
CREATE TABLE IF NOT EXISTS `payment_order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `payment_id` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `amount` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `currency` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` datetime NOT NULL,
  `payer_paypal_email` longtext COLLATE utf8mb4_unicode_ci,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `payment_order`
--

INSERT INTO `payment_order` (`id`, `payment_id`, `status`, `amount`, `currency`, `created_at`, `payer_paypal_email`) VALUES
(1, 'Pour le Paypal', 'approved', '100', 'EUR', '2019-03-13 07:42:06', NULL),
(2, 'Pour le Paypal', 'approved', '100', 'EUR', '2019-03-13 07:42:06', NULL),
(3, 'Pour le Paypal', 'approved', '100', 'EUR', '2019-03-13 07:42:06', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `categorie_produit_id` int(11) DEFAULT NULL,
  `titre` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `image` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prix` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `IDX_29A5EC2791FDB457` (`categorie_produit_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`id`, `categorie_produit_id`, `titre`, `description`, `image`, `prix`) VALUES
(1, 1, 'T-shirt Collection n°1', 'Edition Speciale', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAM0_BJKsv2rWNB2DWxbaHahLjBZH-GImrY4CPpuJ7qa49F81Y', 101),
(2, 1, 'T-shirt Collection n°2', 'Edition Speciale', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAM0_BJKsv2rWNB2DWxbaHahLjBZH-GImrY4CPpuJ7qa49F81Y', 102),
(3, 1, 'T-shirt Collection n°3', 'Edition Speciale', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAM0_BJKsv2rWNB2DWxbaHahLjBZH-GImrY4CPpuJ7qa49F81Y', 103),
(4, 2, 'Pull Collection n°1', 'Edition Speciale', 'https://images-na.ssl-images-amazon.com/images/I/81jNqMIbRCL._SY355_.jpg', 101),
(5, 2, 'Pull Collection n°2', 'Edition Speciale', 'https://images-na.ssl-images-amazon.com/images/I/81jNqMIbRCL._SY355_.jpg', 102),
(6, 2, 'Pull Collection n°3', 'Edition Speciale', 'https://images-na.ssl-images-amazon.com/images/I/81jNqMIbRCL._SY355_.jpg', 103),
(7, 5, 'Short Collection n°1', 'Edition Speciale', 'https://cdn.leslipfrancais.fr/1921-thickbox_default/le-capitaine-short-de-bain-bleu-marine.jpg', 101),
(8, 5, 'Short Collection n°2', 'Edition Speciale', 'https://cdn.leslipfrancais.fr/1921-thickbox_default/le-capitaine-short-de-bain-bleu-marine.jpg', 102),
(9, 5, 'Short Collection n°3', 'Edition Speciale', 'https://cdn.leslipfrancais.fr/1921-thickbox_default/le-capitaine-short-de-bain-bleu-marine.jpg', 103),
(10, 3, 'Veste Collection n°1', 'Edition Speciale', 'https://ol-boutique-cdn-2.azureedge.net/17481-large_default/veste-anthem-ol-adulte-noir-2018-19.jpg', 101),
(11, 3, 'Veste Collection n°2', 'Edition Speciale', 'https://ol-boutique-cdn-2.azureedge.net/17481-large_default/veste-anthem-ol-adulte-noir-2018-19.jpg', 102),
(12, 3, 'Veste Collection n°3', 'Edition Speciale', 'https://ol-boutique-cdn-2.azureedge.net/17481-large_default/veste-anthem-ol-adulte-noir-2018-19.jpg', 103),
(13, 4, 'Pantalon Collection n°1', 'Edition Speciale', 'https://ol-boutique-cdn-3.azureedge.net/16780-home_default/pantalon-34-entrainement-olympique-lyonnais-adulte-noir-20182019.jpg', 101),
(14, 4, 'Pantalon Collection n°2', 'Edition Speciale', 'https://ol-boutique-cdn-3.azureedge.net/16780-home_default/pantalon-34-entrainement-olympique-lyonnais-adulte-noir-20182019.jpg', 102),
(15, 4, 'Pantalon Collection n°3', 'Edition Speciale', 'https://ol-boutique-cdn-3.azureedge.net/16780-home_default/pantalon-34-entrainement-olympique-lyonnais-adulte-noir-20182019.jpg', 103);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `commande_order`
--
ALTER TABLE `commande_order`
  ADD CONSTRAINT `FK_CC414C5B8E54FB25` FOREIGN KEY (`livraison_id`) REFERENCES `livraison_order` (`id`),
  ADD CONSTRAINT `FK_CC414C5BA76ED395` FOREIGN KEY (`user_id`) REFERENCES `fos_user` (`id`),
  ADD CONSTRAINT `FK_CC414C5BCD592F50` FOREIGN KEY (`payment_order_id`) REFERENCES `payment_order` (`id`),
  ADD CONSTRAINT `FK_CC414C5BFF3ED4A8` FOREIGN KEY (`identity_id`) REFERENCES `identity_order` (`id`);

--
-- Contraintes pour la table `commande_order_produit`
--
ALTER TABLE `commande_order_produit`
  ADD CONSTRAINT `FK_3EEB21D45BBF75A2` FOREIGN KEY (`commande_order_id`) REFERENCES `commande_order` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_3EEB21D4F347EFB` FOREIGN KEY (`produit_id`) REFERENCES `produit` (`id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `identity_user`
--
ALTER TABLE `identity_user`
  ADD CONSTRAINT `FK_39E1FCDA76ED395` FOREIGN KEY (`user_id`) REFERENCES `fos_user` (`id`);

--
-- Contraintes pour la table `livraison_user`
--
ALTER TABLE `livraison_user`
  ADD CONSTRAINT `FK_2662B5F8A76ED395` FOREIGN KEY (`user_id`) REFERENCES `fos_user` (`id`);

--
-- Contraintes pour la table `panier`
--
ALTER TABLE `panier`
  ADD CONSTRAINT `FK_24CC0DF2A76ED395` FOREIGN KEY (`user_id`) REFERENCES `fos_user` (`id`);

--
-- Contraintes pour la table `panier_produit`
--
ALTER TABLE `panier_produit`
  ADD CONSTRAINT `FK_D31F28A6F347EFB` FOREIGN KEY (`produit_id`) REFERENCES `produit` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_D31F28A6F77D927C` FOREIGN KEY (`panier_id`) REFERENCES `panier` (`id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `produit`
--
ALTER TABLE `produit`
  ADD CONSTRAINT `FK_29A5EC2791FDB457` FOREIGN KEY (`categorie_produit_id`) REFERENCES `categorie` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
