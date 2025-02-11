using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class MotCleService
    {
        public List<MotCle> GetListMotCle()
        {
            List<MotCle> listmotcle = new List<MotCle>();

            listmotcle.Add(new MotCle(1, "Abhumain", "Certaines souches mutantes de l'humanité, telles que les Ogryns musclés, surdimensionnés et impeccablement fidèles, sont autorisées à devenir citoyennes dans quelques régions de l'Imperium en raison de leur utilié. Ces mutants sont connus sous le nom d'Abhumains."));
            listmotcle.Add(new MotCle(2, "Adepta Sororitas", "Une secte de nonnes guerrières vertueuses qui forment l'armée de l'Adeptus Administratum et mènent des Guerres de la foi pour voir la volonté de l'Empereur-Dieu accomplie."));
            listmotcle.Add(new MotCle(3, "Adeptus Administratum", "L'organisation bureaucratique colossale qui gouverne l'Imperium . Ses membres tiennent les registres, prélèvent les dîmes, assemblent les munition et remplissent une multitude d'autres tâches administratives."));
            listmotcle.Add(new MotCle(4, "Adeptus Astartes", "Les Spaces Marines, des super soldats transhumains génétiquement améliorés qui ne connaissent pas la peur."));
            listmotcle.Add(new MotCle(5, "Adeptus Astra Telepathica", "L'organisation responsable du recrutement et de la formation des Psykers pour l'imperium."));
            listmotcle.Add(new MotCle(6, "Adeptus Mechanicus", "Les membres du Culte Mechanicus, le Culte de la machine basé sur Mars qui fournit à l'Imperium sa technologie de pointe et protège la connaissance sacrée de son fonctinonnement."));
            listmotcle.Add(new MotCle(7, "Adeptus Ministorum", "L'église d'Etat de l'Imperium qui propage et maintient le culte de l'Empreur-Dieu pour unir Son peuple."));
            listmotcle.Add(new MotCle(8, "Aeldari", "Une ancienne espèce xenos dont l'empire en déclin s'étendait autrefois dans toute la galaxie. Ils sont naturellement psychiques, vivent longtemps et sont de vieux ennemis de l'Imperium."));
            listmotcle.Add(new MotCle(9, "Aeronautica Imperialius", "L'Aeraunotica Imperialis fait partie de la Navis Imperialis et est responsable de l'aviation impériale dans l'atsmosphère."));
            listmotcle.Add(new MotCle(10, "Anhrathe", "Anhrathe est le nom Aeldari des Corsaires, les pirates parias qui forment des Coteries."));
            listmotcle.Add(new MotCle(11, "Arlequin", "Les adorateurs impénétrables du Dieu rieur Cegorach. Les Arlequins sont des Aeldari qui parcourent la galaxie en troupes, organisent des reconstitutions théâtrales de l'histoire Aeldari et interviennent dans les combats avec une efficacité mortelle."));
            listmotcle.Add(new MotCle(12, "Astra Carttographica", "Sous-faction de l'Administratum, l'Astra Cartographica est chargée de cartographier la vaste étendu de la galaxie."));
            listmotcle.Add(new MotCle(13, "Astra Militarum", "La plus grande force militaire de l'Imperium, dont les rangs rassemblent des milliards d'humains mortels."));
            listmotcle.Add(new MotCle(14, "Asuryani", "Le nom Aeldari pour les citoyens qui mènent une vie disciplinée sur les Vaisseaux-mondes."));
            listmotcle.Add(new MotCle(15, "Bête", "Des créatures inintelligentes qui ne possèdent pas la conscience de soi et les capacités intellectuelles développées des humains."));
            listmotcle.Add(new MotCle(16, "Chaos", "Les forces et adorateurs des dieux du Chaos."));
            listmotcle.Add(new MotCle(17, "Châsse Fantôme", "Chaque Asuryani porte une Pierre-esprit, un dispositif qui capturera son âme à sa mort pour la protéger des prédation de l'Assoiffée. Ces Pierres-esprit peuvent être attachées à des dispositifs composés de moelle spectrale pour les alimenter avec la capacité psychique naissante de l'âme des Aeldari. Une châsse Fantôme est un corps artficiel qui peut être contrôlé par une Pierre-esprit, afin d'offiri à l'Aeldari choisi un semblant de vie au-dela de la mort."));
            listmotcle.Add(new MotCle(18, "Culte Genestealer", "Dans le cadre de son cucle de vie naturel, un Genestealer infecte d'autres créatures, afin de déformer leur esprit et leur corps pour servir les Tyranides alors qu'il grandit en puissance et planifie une insurrection totale. Les formes de vie hybrides et endoctrinées qui vénèrent le Patriarche Genstealer sont connues sous le nom de cultistes Genstealer."));
            listmotcle.Add(new MotCle(19, "Démon", "Les créatures malveillantes originaires de l'Immaterium sont appelées démons et sont censées être constituées d'énergie Warp."));
            listmotcle.Add(new MotCle(20, "Drukhari", "Cruels et dépravés, les \"Eldars noirs\" sont des Aeldari qui ont complètement succombé à l'hédonisme sans limitte de leur espève. Depuis la chute des Aeldari, ils vivent à Commorragh, l'immonde métropole de la Toile, où leurs âmes tordues subsistenet sur les émanations psychiques de la souffrance  de leurs nombreux escalves."));
            listmotcle.Add(new MotCle(21, "Guerrier Aspect", "Les Asuryani qui suivent la Voie du Guerrier se consacrent à un aspect spécifique de Khaine, le dieu Aeldari de la guerre. Ces Asuryani sont connus sous le nom de Guerrier Aspects."));
            listmotcle.Add(new MotCle(22, "Hérétique", "Ceux qui ont péché, blasphémé ou se sont détournés de la lumière de l'Empereur sont appelés hérétiques."));
            listmotcle.Add(new MotCle(23, "Imperium", "Le vaste empire interstellaire de l'humanité qui s'étend sur plus d'un million de mondes, dirigé par l'Emperuer depuis Sainte Terra."));
            listmotcle.Add(new MotCle(24, "Inquisition", "Une organisation clandestine dotée du pouvoir absolu pour combattre les plus grandes menaces qui pèsent sur l'Imperium: l'héréie, les xenos et le démons."));
            listmotcle.Add(new MotCle(25, "Jokaero", "Une espèce xenos de type simien avec une incroyable compréhension innée de la technologie"));
            listmotcle.Add(new MotCle(26, "Khorne", "Une des Puissances de la Ruine. Les domaines du Dieu du Sang sont les actes de violence, le meurtre et la brutalité."));
            listmotcle.Add(new MotCle(27, "Kroot", "Une expèce de mercenaire xenos capable de contrôler son évolution en consommant d'autres formes de vie."));
            listmotcle.Add(new MotCle(28, "Mechanicum Noir", "Traîtres et renégats du Culte Mechanicus, les adeptes du Mechanicum Noir sont coupable de nombreux péchés, notamment ceux d'adorer le Chaos, d'abuser de technologie interdites et d'inover, y compris la pratique abjecte qui consiste à incorporer des démons dans des dispositifs technologiques."));
            listmotcle.Add(new MotCle(29, "Militarum Auxilia", "une division de l'Astra Militarum qui se compose d'Abhumains."));
            listmotcle.Add(new MotCle(30, "Militarum Tempestus", "Une division de l'Astra Militarum qui fournit des soldats d'élite pour les opérations spéciales."));
            listmotcle.Add(new MotCle(31, "Mutant", "Les humains qui ont dévié de la forme pure définie par l'Ecclesiarchie en raison de l'influence maligne du Warp sont connus sous le nom de mutant."));
            listmotcle.Add(new MotCle(32, "Navis Imperialis", "L'organisation impériale responsable du fonctionnement et de l'utilisation des vaisseaux spaciaux. La Navis Imperialis, ou Marine Impériale, transporte l'Astra Militarum entre chaque zone de conflit parmi les millions qui affligent l'Imperium, et s'engage en combat spatial contre les nombreux ennemis de l'Imperium qui rôdent dans le vide interstellaire."));
            listmotcle.Add(new MotCle(33, "Navis Nobilite", "Une ancienne famille de noble étendu de mutants humains assermentés, qui possèdent tous la capacité héréditaire de naviguer à travers le marées changeantes du Warp et de guider un vaisseau spatial sur les mers de l'Empyrée."));
            listmotcle.Add(new MotCle(34, "Nécron", "Une epsèce préhistorique de xénos robotiques immortels qui reviennt à la vie après plusieurs millénaires de sommeil. Les Nécrons utilisent une technologie bien plus avancée que celle de toute autre espèce vivante dans leur quête pour reconquérir la galaxie."));
            listmotcle.Add(new MotCle(35, "Nurgle", "Une des Puissance de la Ruine. Les domaines du Dieu des Epidémies sont la maladie, la décomposition et l'entropie."));
            listmotcle.Add(new MotCle(36, "Officio Assassinorum", "Une organiosation impériale clandestine qui forme les assassins les plus redoutables de toute l'humanité."));
            listmotcle.Add(new MotCle(37, "Officio Prefectus", "L'organisation impériale qui recrute et forme les Commissaires."));
            listmotcle.Add(new MotCle(38, "Ork", "Une espèce xenos brutale qui a toujours soif de violence et ne vite que pour la guerre."));
            listmotcle.Add(new MotCle(39, "Primaris", "Une nouvelle forme de Space Marines transhumains, encore plus puissante que leurs frères de l'Adeptus Astartes."));
            listmotcle.Add(new MotCle(40, "Questor Mechanicus", "Les marcheurs de combats robotiques connus sous le nom de Chevalier Imperiaux sont appelés QUesttor Mechanicus en haut gothique. Fort de ses titres de noblesse ancestraux suy un des nombreux Mondes Chevaliers féodaux de l'Iperium, un seul Chevalier peut renverser le cours d'une bataille grâce aux millénaires d'expériences au combat transmis par le Trône Mechanicum."));
            listmotcle.Add(new MotCle(41, "Racaille", "La lie de la socété impériale, qui évolue en dehors des autres factions et, bien souvent dans l'illégalité."));
            listmotcle.Add(new MotCle(42, "Rogue Trader", "Détenteurs de Lettre de Marque, les Livres Marchands sont habilités à explorer, conquérir et commercer au-delà des frontières de l'Imperium pour étendre le royaume de l'Empereur."));
            listmotcle.Add(new MotCle(43, "Scholastia Psykana", "En tant que division de l'Adeptus Astra Telepathiuca, la Scholastia Psykana est chargée d'examiner les Psykers amenés sur Terra par les vaisseaux noirs et de les entraîner pour déterminer leur uriliré pour l'Imperium."));
            listmotcle.Add(new MotCle(44, "Serviteur", "L'I.A, ou intelligence abominable, est un péché mortel pour le Culte Mechanicus. Leurs nombreux domestiques technologiques, connus sous le nom de Servitors, sont tous construits autour de cerveaux biologiques complétés par des mécanismes sacrés."));
            listmotcle.Add(new MotCle(45, "Skitarii", "Les humains fortement augmentés connus sous le nom de Skitarii forment les armées mécanisées éternellement dévouées du Culte Mechanicus."));
            listmotcle.Add(new MotCle(46, "Slaneesh", "Une des Puissance de la Ruine. Le Seigneur de l'Excès, aussi appelé l'Assoiffée par les Aeldari, revendique le domaine de la décadence, de l'hédonisme et de la recherche de la perfection."));
            listmotcle.Add(new MotCle(47, "T'au", "Une espèce xenos jeune, mais technologiquement avancée. L'Empire T'au s'étend rapidement sur les franges orientales de la galaxie."));
            listmotcle.Add(new MotCle(48, "Tyranides", "Une espèce xenos extra-galactique repoussante dont la seule intention est de dévorer toute autre forme de vie. Bien qu'ils se présentent sous différentes bioformes adaptatives (dont les redoutables Genestealers), les Tyranides sont tous reliés enter eux par l'exsprit de la ruche. En raison de ce lien télépatique, ce sont des adversaiures déterminés et terrifiants, qui se battent avec de répugnates armes biotechnologiques."));
            listmotcle.Add(new MotCle(49, "Tzeentch", "Une des Puissances de la Ruine. Les domaines du maître du changement sont le destin, l'ambition et la sorcellerie."));
            listmotcle.Add(new MotCle(50, "Ynnari", "Une sous-faction religieuse des Aeldari récemment émergente. Les Ynnari cherchent à unir les Asuryani, les Drukhari, les Arlequins et les Errants. Leur miussion ultime est de réveiller Ynnead, le dieu Aeldari des morts, afin qu'il puisse vaincre l'Assoiffée et permettre aux Aeldari de redevenir les maîtres de la galaxie."));
            listmotcle.Add(new MotCle(51, "Adeptus Arbites", ""));
            listmotcle.Add(new MotCle(101, "[Chapitre]", "Chaque Space Marine appartiuent à un Chapitre, Une organisation de 1000 Adeptus Astartes avec leurs propres principes, cultures, traditions et gènes."));
            listmotcle.Add(new MotCle(102, "[Clan]", "Un clan Ork est un état d'esprit culturel ou une pgilosophie intemporelle qui réunit de nombreux Orks. Chacun se concentre sur une partie spécifique de la kiltur' Ork, comme la brutalité, ma ruz' ou le pillaj'."));
            listmotcle.Add(new MotCle(103, "[Coterie]", "Une Coterie est un collectif de Corsaires  ari, un groupe de pirates de l'espace opportunistes qui ont chacun quitté leur ancienne vie pour partir à l'aventure et sassouvir leurs envie hédonistes. Une Coterie est une organisation informelle qui repose sur la camaraderie e des objectifs communs, et peut inlure à la fois des Aeldari et des Drukhari."));
            listmotcle.Add(new MotCle(104, "[Coterie d'Hémoncules]", "Les Hémoncules sont des Drukhari qui maîtrisent l'art d'infliger des tortures particulièrement douloureuses et de remodeler la chair par manipulation biologieque. ILs se réunissent fréquement pour poursuivre leurs objectifs malsains en tant que cotrerie, accoompagnés des monstruosités grotesques qu'ils ont créées."));
            listmotcle.Add(new MotCle(105, "[Culte Céraste]", "Les Drukhari de Commorragh affluent pour se repaître de souffrance devant les spectacles de mort qui ont lieu chaque soir dans les arènes des Cultes Ceraste. Ces démonstrations de violence et de souleur sont comme de la nourriture pour leurs âmes dépravées. Chaque Culte utilise différentes techniques, drogues de combat et armes pour réaliser le massacre le plus glorieux possible."));
            listmotcle.Add(new MotCle(106, "[Dynastie]", "La Lettre de Marque qui confère à un LIbre Marchand son pouvoir est souvent héritable. La rihesse et l'influence de la dynastie d'un Libre Marchand augmentent ainsi au fil des générations. Chaque dynastie peut avoir des ressouces très différentes ou une réputation à déffendre."));
            listmotcle.Add(new MotCle(107, "[Kabale]", "La plupart des Drukhari font partie d'une Kabale immorale, une armée dispersée de pillards et d'esclavagistes qui écument la galaxie grâce à la Toile. Chaque Kabale est dirigées par un Archonte avec ses propres objectifs malfaisants."));
            listmotcle.Add(new MotCle(108, "[Légion]", "Les Légions renégates des Space Marines du Chaos ont chacune leur propre manière de vénérer les dieux du Chaos, mais toutes sont entièrement composées d'infâmes traîtres. Certaines regroupent plusieurs milliers de guerriers, tandis que d'autes ne sont que de simples bandes unis par un objectif commun, dispersées à travers la galaxie et le cauchemar de l'Immaterium."));
            listmotcle.Add(new MotCle(109, "[Marque du Chaos]", "Les personnes qui vénèrent les Puissances de la Ruine peuvent recevoir une Marque du Chaos, une manifestation immonde de la faveur des dieux sombres qui désigne un mortel comme serviteur du Chaos. La plupart de ces traîtres sont marqués de l'étoile à huit branches du Chaos universel, mais certains concentrent leur culte sur un seul dieu et reçoivent en retour lsa marque sépcifique."));
            listmotcle.Add(new MotCle(110, "[Monde-Forge]", "Le Culte Mechanicus revendique de nombreuses planètes impériales, afin d'exploiter leurs ressources minérales et d'en couvrir toute la surface par de vastes manifactorums interconnectés. Chacun a sa propre culture, ses façons d'adorer l'Omnimessie et ses modèles de fabrication spécialisés."));
            listmotcle.Add(new MotCle(111, "[Ordre]", "Les couvents de l'Adepta Sororitas forment de justes serviteurs de l'Empereur-Dieu pour de nombreux rôles, chacun étant connu sous le nom de l'Ordre."));
            listmotcle.Add(new MotCle(112, "[Ordo]", "L'Inquisition comprend plusieurs Ordos sacrés, chacun spécialisé pour combattre clandestinement les plus grandes menaces qui pèsent sur l'Imperium."));
            listmotcle.Add(new MotCle(113, "[Régiment]", "Chacune des divreses planètes de l'Imperium doit une dîme de guerriers à l'Empereur pour mener ses guerres saintes. En raison de la grande variété de planètes (des Monde Hostiles recouverts de jungle aux mondes industriels honorables) qui composent l'Imperium, chaque Régiment planètaire est très différent en termes d'entrainement, de techniques et d'équipement."));
            listmotcle.Add(new MotCle(114, "[Vaisseau-Monde]", "Un Vaisseau-Monde est un vaisseau gigantesque en moelle spectrale de la taille d'une petite planète qui abrite une énorme population d'Aeldari Asuryani. Chaque Vaisseau-Monde a sa propre culture et est alimenté par un Circuit d'infinité qui abrite les esprits de ses citoyens décédés."));
            listmotcle.Add(new MotCle(201, "A 2 mains", "Une arme qui necessite deux mains pour être maniée."));
            listmotcle.Add(new MotCle(202, "Aiguille", "Ces armes silencieusrs ont un mécanisme de tir en deux étapes: un laser invisible qui pénètre la peau, suivi d'une aiguille cristalline imbibée de neurotoxine peour éliminer impitoyablement les ennemis à distance."));
            listmotcle.Add(new MotCle(203, "Bolt", "Une arme à feu qui tire des obus autopropulsés à masse réactiuve connus sous le nom de bolts, qui explosent lorsqu'il pénètrent un ennemi."));
            listmotcle.Add(new MotCle(204, "Champ de force", "Ces armes de mêlées sont enveloppées de champ de force qui perturbent la matière, afin de traverser facilement l'armure."));
            listmotcle.Add(new MotCle(205, "Énergétique", "La céramite, l'adamantium et le plastacier ne sont que quelque-uns des matériaux ultra-lourds utilisés pour protéger les guerriers impériaux contre les innombrables menaces du 41° millénaire. Une telle armure serait trop lourde pour être portée sans les faisceaux de fibres motrices électriques qui amplifient et reproduissent les movements du porteur, afin d'atténuer le poids et d'améliorer la force du porteur. Une armure capable d'amplifier la force de son porteur de cette manière est connue sous le nom d'armure énergétique."));
            listmotcle.Add(new MotCle(206, "Explosif", "Une arme qui explose ou tire des explosifs."));
            listmotcle.Add(new MotCle(207, "Exotique", "Une arme étrange ou inhabituelle qui défie les catégorisations habituelles."));
            listmotcle.Add(new MotCle(208, "Flamme", "Une arme qui tire des flammes ou utilise le feu."));
            listmotcle.Add(new MotCle(209, "Force", "Les Psykers peuvent canaliser les énergies Warp dans une arme de force, afin d'amplifier de façon surnaturelle la puissance de leurs coups."));
            listmotcle.Add(new MotCle(210, "Fusion", "Ces armes à feu thermiques alimentées par une technologie subatomique tirent des faisceaux concentrés de chaleur extrême et consituent d'escellentes armes anti-blindage."));
            listmotcle.Add(new MotCle(211, "Lame", "Une arme à lame simple, comme une épée ou un couteau."));
            listmotcle.Add(new MotCle(212, "Laser", "Produites en série, faciles à entretenir et alimentées par des cellules énergétiques, les armes à laser font partie de l'équipement standard des forces de l'Imperium."));
            listmotcle.Add(new MotCle(213, "Léger", "Un équipement particulièrement léger."));
            listmotcle.Add(new MotCle(214, "Légère", "Un équipement particulièrement léger."));
            listmotcle.Add(new MotCle(215, "Lourd", "Un équipement particulièrement lourd."));
            listmotcle.Add(new MotCle(216, "Lourde", "Un équipement particulièrement lourd."));
            listmotcle.Add(new MotCle(217, "Pare-balles", "Une forme d'armure robuste, légère et produite en série."));
            listmotcle.Add(new MotCle(218, "Plasma", "Une arme à feu avancée qui tire des imuplsions mortelles de matière surchauffée. Ces armes sont à la fois vénérées pour leur potentiel destructeur et redoutées pour leur instabilité."));
            listmotcle.Add(new MotCle(219, "Primitive", "Un équipement qui utilise une technologie obsolète."));
            listmotcle.Add(new MotCle(220, "Projectile", "Une arme à feu qui utiliser la technologie antique de la pourde à canon pour propulser de simples balles métalliques à grande vitesse."));
            listmotcle.Add(new MotCle(221, "Shuriken", "La technologie avancée des Aeldari leur permet de frabriquer de munitions en plasti-cristaux monomoléculaires qui tranchent la chair et l'armure lorsqu'elles sont tirées. Ces armes utilisent généralement des impulsions gravitiques pour lancer des shurikens à des vitesses si rapides qu'ils hurlent dans les airs."));
            listmotcle.Add(new MotCle(222, "Tronçonneuse", "Une arme qui utilise des dents acérées et motorisées pour infliger un maximum de dégâts."));
            listmotcle.Add(new MotCle(301, "Aeldari", "Un poPouvoir Psychique avancé utilisé uniquement par l'espèce des Aeldari."));
            listmotcle.Add(new MotCle(302, "Audition", "Un Pouvoir Psychique qui a un effet audible"));
            listmotcle.Add(new MotCle(303, "Chaos", "Une Pouvoir Psychique utilisé uniquement par les forces du Chaos"));
            listmotcle.Add(new MotCle(304, "Cinétique", "Un Pouvoir Psychique qui manifeste une force cinétique pour déplacer quelque chose dans l'espace réel."));
            listmotcle.Add(new MotCle(305, "Feu", "Un Pouvoir Psychique qui manipule la chaleur ou invoque des flammes."));
            listmotcle.Add(new MotCle(306, "Lumière", "Un Pouvoir Psychique qui produit de la lumière."));
            listmotcle.Add(new MotCle(307, "Psychique", "Un Mot-Clé associé à chaque Pouvoir Psychique."));
            listmotcle.Add(new MotCle(308, "Télépathie", "Un Pouvoir Psychique qui permet au Psyker d'entrer dans l'esprit d'un autre indivisu."));
            listmotcle.Add(new MotCle(999, "[Au CHoix]", "Vous pouvez remplacer ce Mot-Clé par un Mot-Clé de votre choix. Si un équipement possède ce Mot-Clé, il est disponible pour tout le monde."));
            //listmotcle.Add(new MotCle(, "", ""));

            return listmotcle;
        }
    }
}