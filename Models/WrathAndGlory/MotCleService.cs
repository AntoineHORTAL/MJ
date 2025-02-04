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
            //listmotcle.Add(new MotCle(, "", ""));

            return listmotcle;
        }
    }
}